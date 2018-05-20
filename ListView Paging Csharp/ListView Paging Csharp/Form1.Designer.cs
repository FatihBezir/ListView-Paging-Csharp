namespace ListView_Paging_Csharp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.FistPage = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.LastPage = new System.Windows.Forms.Button();
            this.TextPageNumber = new System.Windows.Forms.Label();
            this.ShowAll = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 274);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FistPage
            // 
            this.FistPage.Location = new System.Drawing.Point(74, 271);
            this.FistPage.Name = "FistPage";
            this.FistPage.Size = new System.Drawing.Size(75, 23);
            this.FistPage.TabIndex = 2;
            this.FistPage.Text = "FistPage";
            this.FistPage.UseVisualStyleBackColor = true;
            this.FistPage.Click += new System.EventHandler(this.FistPage_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(156, 271);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(278, 271);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // LastPage
            // 
            this.LastPage.Location = new System.Drawing.Point(359, 271);
            this.LastPage.Name = "LastPage";
            this.LastPage.Size = new System.Drawing.Size(75, 23);
            this.LastPage.TabIndex = 5;
            this.LastPage.Text = "LastPage";
            this.LastPage.UseVisualStyleBackColor = true;
            this.LastPage.Click += new System.EventHandler(this.LastPage_Click);
            // 
            // TextPageNumber
            // 
            this.TextPageNumber.AutoSize = true;
            this.TextPageNumber.Location = new System.Drawing.Point(237, 276);
            this.TextPageNumber.Name = "TextPageNumber";
            this.TextPageNumber.Size = new System.Drawing.Size(24, 13);
            this.TextPageNumber.TabIndex = 6;
            this.TextPageNumber.Text = "1/1";
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(440, 271);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(75, 23);
            this.ShowAll.TabIndex = 7;
            this.ShowAll.Text = "ShowAll";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 253);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 306);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.TextPageNumber);
            this.Controls.Add(this.LastPage);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.FistPage);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "ListView Paging";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button FistPage;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button LastPage;
        private System.Windows.Forms.Label TextPageNumber;
        private System.Windows.Forms.Button ShowAll;
        private System.Windows.Forms.ListView listView1;
    }
}

