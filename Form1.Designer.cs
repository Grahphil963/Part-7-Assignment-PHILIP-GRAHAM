namespace Part_7_Assignment_PHILIP_GRAHAM
{
    partial class UsingLists
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
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.lblRemoveInstructions = new System.Windows.Forms.Label();
            this.lblHeroAddInstructions = new System.Windows.Forms.Label();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.lblRemoveHeroInstructions = new System.Windows.Forms.Label();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(71, 22);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(49, 13);
            this.lblNumbers.TabIndex = 0;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Location = new System.Drawing.Point(294, 9);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(41, 13);
            this.lblHeroes.TabIndex = 1;
            this.lblHeroes.Text = "Heroes";
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Location = new System.Drawing.Point(11, 69);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnNewNumbers.TabIndex = 2;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Location = new System.Drawing.Point(92, 69);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(75, 23);
            this.btnSortNumbers.TabIndex = 3;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Location = new System.Drawing.Point(233, 41);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnNewHeroes.TabIndex = 4;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Location = new System.Drawing.Point(314, 41);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(75, 23);
            this.btnSortHeroes.TabIndex = 5;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(11, 98);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(156, 95);
            this.lstNumbers.TabIndex = 6;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(233, 85);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(156, 95);
            this.lstHeroes.TabIndex = 7;
            // 
            // lblRemoveInstructions
            // 
            this.lblRemoveInstructions.AutoSize = true;
            this.lblRemoveInstructions.Location = new System.Drawing.Point(11, 208);
            this.lblRemoveInstructions.Name = "lblRemoveInstructions";
            this.lblRemoveInstructions.Size = new System.Drawing.Size(134, 13);
            this.lblRemoveInstructions.TabIndex = 8;
            this.lblRemoveInstructions.Text = "Select a number to remove";
            // 
            // lblHeroAddInstructions
            // 
            this.lblHeroAddInstructions.AutoSize = true;
            this.lblHeroAddInstructions.Location = new System.Drawing.Point(230, 195);
            this.lblHeroAddInstructions.Name = "lblHeroAddInstructions";
            this.lblHeroAddInstructions.Size = new System.Drawing.Size(130, 13);
            this.lblHeroAddInstructions.TabIndex = 9;
            this.lblHeroAddInstructions.Text = "Enter a hero name to add:";
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(233, 234);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(100, 20);
            this.txtAddHero.TabIndex = 10;
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(233, 302);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveHero.TabIndex = 11;
            // 
            // lblRemoveHeroInstructions
            // 
            this.lblRemoveHeroInstructions.AutoSize = true;
            this.lblRemoveHeroInstructions.Location = new System.Drawing.Point(230, 269);
            this.lblRemoveHeroInstructions.Name = "lblRemoveHeroInstructions";
            this.lblRemoveHeroInstructions.Size = new System.Drawing.Size(118, 13);
            this.lblRemoveHeroInstructions.TabIndex = 12;
            this.lblRemoveHeroInstructions.Text = "Enter a hero to remove:";
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(339, 232);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(75, 23);
            this.btnAddHero.TabIndex = 13;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(339, 300);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveHero.TabIndex = 14;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Location = new System.Drawing.Point(11, 250);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveNumber.TabIndex = 15;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(92, 250);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveAll.TabIndex = 16;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 325);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Status:";
            // 
            // UsingLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 348);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.lblRemoveHeroInstructions);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.lblHeroAddInstructions);
            this.Controls.Add(this.lblRemoveInstructions);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNumbers);
            this.Name = "UsingLists";
            this.Text = "Using Lists";
            this.Load += new System.EventHandler(this.UsingLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Label lblRemoveInstructions;
        private System.Windows.Forms.Label lblHeroAddInstructions;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.TextBox txtRemoveHero;
        private System.Windows.Forms.Label lblRemoveHeroInstructions;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label lblStatus;
    }
}

