using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace диплом
{
    public class WordExporter
    {
        public void WordExport(DataGridView myGrid)
        {
            if (myGrid == null || myGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Данные для экспорта не обнаружены.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;
            var wordDoc = wordApp.Documents.Add();
            
            try
            {
                // Вставка таблицы из DataGridView
                InserDataWord(wordDoc, myGrid);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при экспорте", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                // Освобождаем ресурс
                Marshal.ReleaseComObject(wordDoc);
                Marshal.ReleaseComObject(wordApp);

            }

        }
        private void InserDataWord(Document doc,DataGridView dgv) 
        { 
            var table = doc.Tables.Add(doc.Range(), dgv.Rows.Count + 1, dgv.Columns.Count);

            // Цикл на заполнения наименование таблицы 
            for (int j = 0; j < dgv.Columns.Count; j++)
            {
                table.Rows[1].Cells[j + 1].Range.Text = dgv.Columns[j].HeaderText;
            }
            // Два цикла Фор для заполнения ячейка 
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for(int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv[j, i] != null)//идёт проверка если ячейка не пустая то стовляем её значения в таблицу 
                    {
                        table.Rows[i + 2].Cells[j + 1].Range.Text = dgv[j, i].Value.ToString();
                    }

                }
            }

            table.Rows[1].Range.Font.Bold = 1;
            table.Rows[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            table.Range.ParagraphFormat.SpaceAfter = 1;
            table.Borders.Enable = 1;
        }
    }
}
