namespace SoftverZaTrgovinu.Forms
{
    partial class frmProdaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCategory = new System.Windows.Forms.Panel();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.tabControlBill = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.listBoxBill = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.listBoxFinishBill = new System.Windows.Forms.ListBox();
            this.panelArticles = new System.Windows.Forms.Panel();
            this.tbArticles = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.tabControlBill.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategory
            // 
            this.panelCategory.AutoScroll = true;
            this.panelCategory.BackColor = System.Drawing.SystemColors.Control;
            this.panelCategory.Location = new System.Drawing.Point(12, 12);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(444, 84);
            this.panelCategory.TabIndex = 0;
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTransaction.Location = new System.Drawing.Point(462, 12);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(153, 58);
            this.btnNewTransaction.TabIndex = 1;
            this.btnNewTransaction.Text = "New transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = false;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // tabControlBill
            // 
            this.tabControlBill.Controls.Add(this.tabInput);
            this.tabControlBill.Controls.Add(this.tabBill);
            this.tabControlBill.Location = new System.Drawing.Point(462, 76);
            this.tabControlBill.Name = "tabControlBill";
            this.tabControlBill.SelectedIndex = 0;
            this.tabControlBill.Size = new System.Drawing.Size(355, 222);
            this.tabControlBill.TabIndex = 2;
            // 
            // tabInput
            // 
            this.tabInput.Controls.Add(this.listBoxBill);
            this.tabInput.Controls.Add(this.btnDelete);
            this.tabInput.Controls.Add(this.btnNext);
            this.tabInput.Controls.Add(this.lbTotalBill);
            this.tabInput.Location = new System.Drawing.Point(4, 25);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(347, 193);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // listBoxBill
            // 
            this.listBoxBill.FormattingEnabled = true;
            this.listBoxBill.ItemHeight = 16;
            this.listBoxBill.Location = new System.Drawing.Point(7, 7);
            this.listBoxBill.Name = "listBoxBill";
            this.listBoxBill.Size = new System.Drawing.Size(214, 132);
            this.listBoxBill.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(228, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 56);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(228, 153);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 36);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBill.Location = new System.Drawing.Point(6, 159);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(0, 22);
            this.lbTotalBill.TabIndex = 1;
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.btnSaveBill);
            this.tabBill.Controls.Add(this.listBoxFinishBill);
            this.tabBill.Location = new System.Drawing.Point(4, 25);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(347, 193);
            this.tabBill.TabIndex = 1;
            this.tabBill.Text = "Bill";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBill.Location = new System.Drawing.Point(231, 134);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(109, 50);
            this.btnSaveBill.TabIndex = 1;
            this.btnSaveBill.Text = "Save bill";
            this.btnSaveBill.UseVisualStyleBackColor = true;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // listBoxFinishBill
            // 
            this.listBoxFinishBill.FormattingEnabled = true;
            this.listBoxFinishBill.ItemHeight = 16;
            this.listBoxFinishBill.Location = new System.Drawing.Point(4, 4);
            this.listBoxFinishBill.Name = "listBoxFinishBill";
            this.listBoxFinishBill.Size = new System.Drawing.Size(221, 180);
            this.listBoxFinishBill.TabIndex = 0;
            // 
            // panelArticles
            // 
            this.panelArticles.Location = new System.Drawing.Point(13, 108);
            this.panelArticles.Name = "panelArticles";
            this.panelArticles.Size = new System.Drawing.Size(443, 484);
            this.panelArticles.TabIndex = 3;
            // 
            // tbArticles
            // 
            this.tbArticles.Location = new System.Drawing.Point(10, 3);
            this.tbArticles.Name = "tbArticles";
            this.tbArticles.Size = new System.Drawing.Size(331, 22);
            this.tbArticles.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbArticles);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnInput);
            this.panel2.Controls.Add(this.btnComma);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btnTimes);
            this.panel2.Location = new System.Drawing.Point(466, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 288);
            this.panel2.TabIndex = 4;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(191, 162);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(150, 70);
            this.btnUndo.TabIndex = 14;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(191, 91);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(150, 65);
            this.btnInput.TabIndex = 13;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnComma
            // 
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(124, 238);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(51, 43);
            this.btnComma.TabIndex = 12;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(10, 238);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(108, 43);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(124, 189);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 43);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(67, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 43);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(10, 189);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 43);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(124, 140);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(51, 43);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(67, 140);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(51, 43);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(10, 140);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(51, 43);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(124, 91);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(51, 43);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(67, 91);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(51, 43);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(10, 91);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(51, 43);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimes.Location = new System.Drawing.Point(10, 42);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(51, 43);
            this.btnTimes.TabIndex = 1;
            this.btnTimes.Text = "X";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // frmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 604);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelArticles);
            this.Controls.Add(this.tabControlBill);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.panelCategory);
            this.Name = "frmProdaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmProdaja_Load);
            this.tabControlBill.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.tabBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.TabControl tabControlBill;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.Panel panelArticles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.TextBox tbArticles;
        private System.Windows.Forms.ListBox listBoxBill;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.ListBox listBoxFinishBill;
    }
}