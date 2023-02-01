namespace PZ_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseMassList = new System.Windows.Forms.ListBox();
            this.createMassBtn = new System.Windows.Forms.Button();
            this.proceedBtn = new System.Windows.Forms.Button();
            this.polList = new System.Windows.Forms.ListBox();
            this.otrList = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblOtr = new System.Windows.Forms.Label();
            this.massRazmInputBox = new System.Windows.Forms.TextBox();
            this.inputLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.polRazmBox = new System.Windows.Forms.TextBox();
            this.otrRazmBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // baseMassList
            // 
            this.baseMassList.FormattingEnabled = true;
            this.baseMassList.ItemHeight = 20;
            this.baseMassList.Location = new System.Drawing.Point(211, 52);
            this.baseMassList.Name = "baseMassList";
            this.baseMassList.Size = new System.Drawing.Size(135, 404);
            this.baseMassList.TabIndex = 0;
            // 
            // createMassBtn
            // 
            this.createMassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.createMassBtn.Location = new System.Drawing.Point(9, 345);
            this.createMassBtn.Name = "createMassBtn";
            this.createMassBtn.Size = new System.Drawing.Size(196, 111);
            this.createMassBtn.TabIndex = 1;
            this.createMassBtn.Text = "Создать";
            this.createMassBtn.UseVisualStyleBackColor = false;
            this.createMassBtn.Click += new System.EventHandler(this.createMassBtn_Click);
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.proceedBtn.Enabled = false;
            this.proceedBtn.Location = new System.Drawing.Point(374, 52);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(196, 111);
            this.proceedBtn.TabIndex = 3;
            this.proceedBtn.Text = "Разделить";
            this.proceedBtn.UseVisualStyleBackColor = false;
            this.proceedBtn.Visible = false;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // polList
            // 
            this.polList.FormattingEnabled = true;
            this.polList.ItemHeight = 20;
            this.polList.Location = new System.Drawing.Point(594, 52);
            this.polList.Name = "polList";
            this.polList.Size = new System.Drawing.Size(135, 364);
            this.polList.TabIndex = 2;
            // 
            // otrList
            // 
            this.otrList.FormattingEnabled = true;
            this.otrList.ItemHeight = 20;
            this.otrList.Location = new System.Drawing.Point(735, 52);
            this.otrList.Name = "otrList";
            this.otrList.Size = new System.Drawing.Size(135, 364);
            this.otrList.TabIndex = 4;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clearBtn.Location = new System.Drawing.Point(96, 121);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(109, 66);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = " Очистить";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Изначальный Массив";
            // 
            // lblPol
            // 
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(594, 9);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(124, 20);
            this.lblPol.TabIndex = 7;
            this.lblPol.Text = "Положительные";
            // 
            // lblOtr
            // 
            this.lblOtr.AutoSize = true;
            this.lblOtr.Location = new System.Drawing.Point(735, 9);
            this.lblOtr.Name = "lblOtr";
            this.lblOtr.Size = new System.Drawing.Size(119, 20);
            this.lblOtr.TabIndex = 8;
            this.lblOtr.Text = "Отрицательные";
            // 
            // massRazmInputBox
            // 
            this.massRazmInputBox.Location = new System.Drawing.Point(149, 52);
            this.massRazmInputBox.Name = "massRazmInputBox";
            this.massRazmInputBox.Size = new System.Drawing.Size(56, 27);
            this.massRazmInputBox.TabIndex = 9;
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Location = new System.Drawing.Point(12, 55);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(124, 20);
            this.inputLbl.TabIndex = 10;
            this.inputLbl.Text = "Введите размер:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Размеры:";
            // 
            // polRazmBox
            // 
            this.polRazmBox.Location = new System.Drawing.Point(630, 433);
            this.polRazmBox.Name = "polRazmBox";
            this.polRazmBox.ReadOnly = true;
            this.polRazmBox.Size = new System.Drawing.Size(56, 27);
            this.polRazmBox.TabIndex = 11;
            // 
            // otrRazmBox
            // 
            this.otrRazmBox.Location = new System.Drawing.Point(778, 433);
            this.otrRazmBox.Name = "otrRazmBox";
            this.otrRazmBox.ReadOnly = true;
            this.otrRazmBox.Size = new System.Drawing.Size(56, 27);
            this.otrRazmBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 472);
            this.Controls.Add(this.otrRazmBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.polRazmBox);
            this.Controls.Add(this.inputLbl);
            this.Controls.Add(this.massRazmInputBox);
            this.Controls.Add(this.lblOtr);
            this.Controls.Add(this.lblPol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.otrList);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.polList);
            this.Controls.Add(this.createMassBtn);
            this.Controls.Add(this.baseMassList);
            this.Name = "Form1";
            this.Text = "PZ_7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox baseMassList;
        private Button createMassBtn;
        private Button proceedBtn;
        private ListBox polList;
        private ListBox otrList;
        private Button clearBtn;
        private Label label1;
        private Label lblPol;
        private Label lblOtr;
        private TextBox massRazmInputBox;
        private Label inputLbl;
        private Label label5;
        private TextBox polRazmBox;
        private TextBox otrRazmBox;
    }
}