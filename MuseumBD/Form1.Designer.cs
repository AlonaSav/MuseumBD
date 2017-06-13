namespace MuseumBD
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAdmin = new System.Windows.Forms.Button();
            this.bStudents = new System.Windows.Forms.Button();
            this.bTeachers = new System.Windows.Forms.Button();
            this.bArticles = new System.Windows.Forms.Button();
            this.bMain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bAdmin);
            this.panel1.Controls.Add(this.bStudents);
            this.panel1.Controls.Add(this.bTeachers);
            this.panel1.Controls.Add(this.bArticles);
            this.panel1.Controls.Add(this.bMain);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 606);
            this.panel1.TabIndex = 0;
            // 
            // bAdmin
            // 
            this.bAdmin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdmin.Location = new System.Drawing.Point(3, 562);
            this.bAdmin.Name = "bAdmin";
            this.bAdmin.Size = new System.Drawing.Size(210, 30);
            this.bAdmin.TabIndex = 4;
            this.bAdmin.Text = "Адміністратор";
            this.bAdmin.UseVisualStyleBackColor = true;
            // 
            // bStudents
            // 
            this.bStudents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStudents.Location = new System.Drawing.Point(3, 111);
            this.bStudents.Name = "bStudents";
            this.bStudents.Size = new System.Drawing.Size(210, 30);
            this.bStudents.TabIndex = 3;
            this.bStudents.Text = "Студенти";
            this.bStudents.UseVisualStyleBackColor = true;
            // 
            // bTeachers
            // 
            this.bTeachers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bTeachers.Location = new System.Drawing.Point(3, 75);
            this.bTeachers.Name = "bTeachers";
            this.bTeachers.Size = new System.Drawing.Size(210, 30);
            this.bTeachers.TabIndex = 2;
            this.bTeachers.Text = "Викладачі";
            this.bTeachers.UseVisualStyleBackColor = true;
            // 
            // bArticles
            // 
            this.bArticles.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bArticles.Location = new System.Drawing.Point(3, 39);
            this.bArticles.Name = "bArticles";
            this.bArticles.Size = new System.Drawing.Size(210, 30);
            this.bArticles.TabIndex = 1;
            this.bArticles.Text = "Статті";
            this.bArticles.UseVisualStyleBackColor = true;
            // 
            // bMain
            // 
            this.bMain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMain.Location = new System.Drawing.Point(3, 3);
            this.bMain.Name = "bMain";
            this.bMain.Size = new System.Drawing.Size(210, 30);
            this.bMain.TabIndex = 0;
            this.bMain.Text = "Головна сторінка";
            this.bMain.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.bSearch);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Location = new System.Drawing.Point(219, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 605);
            this.panel2.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 29);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(670, 566);
            this.webBrowser1.TabIndex = 2;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(598, 3);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Пошук";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(2, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(590, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Введіть пошуковий запит";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Музей історії ХНТУ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bStudents;
        private System.Windows.Forms.Button bTeachers;
        private System.Windows.Forms.Button bArticles;
        private System.Windows.Forms.Button bAdmin;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}

