namespace MiniNapoleon
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// 90 
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// 53 
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptButton = new System.Windows.Forms.Button();
            this.EncryptTextbox = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.DecryptTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenCodeTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 25);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(100, 23);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Зашифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // EncryptTextbox
            // 
            this.EncryptTextbox.Location = new System.Drawing.Point(118, 25);
            this.EncryptTextbox.Name = "EncryptTextbox";
            this.EncryptTextbox.Size = new System.Drawing.Size(265, 20);
            this.EncryptTextbox.TabIndex = 1;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(12, 49);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(100, 23);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // DecryptTextbox
            // 
            this.DecryptTextbox.Location = new System.Drawing.Point(118, 51);
            this.DecryptTextbox.Name = "DecryptTextbox";
            this.DecryptTextbox.Size = new System.Drawing.Size(265, 20);
            this.DecryptTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            // 
            // OpenCodeTable
            // 
            this.OpenCodeTable.Location = new System.Drawing.Point(12, 77);
            this.OpenCodeTable.Name = "OpenCodeTable";
            this.OpenCodeTable.Size = new System.Drawing.Size(371, 23);
            this.OpenCodeTable.TabIndex = 5;
            this.OpenCodeTable.Text = "Открыть таблицу с кодами";
            this.OpenCodeTable.UseVisualStyleBackColor = true;
            this.OpenCodeTable.Click += new System.EventHandler(this.OpenCodeTable_Click);
            // 
            // label2
            //
            //115 
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите сообщение без пробелов и знаков K, W, X, Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            //
            //
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 112);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenCodeTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecryptTextbox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptTextbox);
            this.Controls.Add(this.EncryptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Малый Наполеон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox EncryptTextbox;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox DecryptTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenCodeTable;
        private System.Windows.Forms.Label label2;
    }
}

