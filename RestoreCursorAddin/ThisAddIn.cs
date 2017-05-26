using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace RestoreCursorAddin
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.WindowSelectionChange += SelectionChange;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void SelectionChange(Selection selectionText)
        {
            Cursor.Current = Cursors.Default;
            Cursor.Current = Cursors.Arrow;
        }

        #region VSTO で生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}