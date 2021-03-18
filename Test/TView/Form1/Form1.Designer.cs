using System;

namespace Test
{
    partial class Form1Test
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1Test
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1Test";
            this.Load += new System.EventHandler(this.Form1Test_Load);
            this.ResumeLayout(false);

        }



        #endregion

        public System.Windows.Forms.Label lMenuInfo;
        public System.Windows.Forms.Button bPizza;
        public System.Windows.Forms.Button bMainDish;
        public System.Windows.Forms.Button bSoups;
        public System.Windows.Forms.TextBox textBoxQuantityDishes;
        public System.Windows.Forms.Button bAddDish;
        public System.Windows.Forms.Button bRemoveAllListBox;
        public System.Windows.Forms.Panel panelDania;
        public System.Windows.Forms.Button bRemoveListBox;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox tComments;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button bDrinks;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Button bOrder;
        public System.Windows.Forms.Label lPrice;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addressEmailToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        public System.Windows.Forms.ListView listViewOrder;
        public System.Windows.Forms.ColumnHeader Danie;
        public System.Windows.Forms.ColumnHeader Dodatki;
        public System.Windows.Forms.ColumnHeader Cenal;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ListView listViewDish;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.CheckedListBox chListBoxSideDishes;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

