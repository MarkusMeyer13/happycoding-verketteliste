namespace VerketteteListe1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxCompleteList = new System.Windows.Forms.TextBox();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertElement = new System.Windows.Forms.Button();
            this.tbxIndexInsert = new System.Windows.Forms.TextBox();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.tbxNewContent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelFirst = new System.Windows.Forms.Button();
            this.btnDelLast = new System.Windows.Forms.Button();
            this.btnDelOnIndex = new System.Windows.Forms.Button();
            this.tbxIndexDel = new System.Windows.Forms.TextBox();
            this.btnDelOnContent = new System.Windows.Forms.Button();
            this.tbxContentDel = new System.Windows.Forms.TextBox();
            this.tbxAnzElemente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFirstElem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLastElem = new System.Windows.Forms.TextBox();
            this.btnNeueListe = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxCompleteList
            // 
            this.tbxCompleteList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCompleteList.Location = new System.Drawing.Point(54, 385);
            this.tbxCompleteList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxCompleteList.Multiline = true;
            this.tbxCompleteList.Name = "tbxCompleteList";
            this.tbxCompleteList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxCompleteList.Size = new System.Drawing.Size(1328, 92);
            this.tbxCompleteList.TabIndex = 0;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(1236, 325);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(150, 44);
            this.btnShowList.TabIndex = 1;
            this.btnShowList.Text = "Zeige Liste";
            this.btnShowList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1236, 225);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsertElement);
            this.groupBox1.Controls.Add(this.tbxIndexInsert);
            this.groupBox1.Controls.Add(this.btnAddElement);
            this.groupBox1.Controls.Add(this.tbxNewContent);
            this.groupBox1.Location = new System.Drawing.Point(54, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(478, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemente hinzufügen";
            // 
            // btnInsertElement
            // 
            this.btnInsertElement.Location = new System.Drawing.Point(124, 173);
            this.btnInsertElement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInsertElement.Name = "btnInsertElement";
            this.btnInsertElement.Size = new System.Drawing.Size(324, 44);
            this.btnInsertElement.TabIndex = 3;
            this.btnInsertElement.Text = "Element einfügen bei";
            this.btnInsertElement.UseVisualStyleBackColor = true;
            this.btnInsertElement.Visible = false;
            // 
            // tbxIndexInsert
            // 
            this.tbxIndexInsert.Location = new System.Drawing.Point(36, 177);
            this.tbxIndexInsert.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxIndexInsert.Name = "tbxIndexInsert";
            this.tbxIndexInsert.Size = new System.Drawing.Size(72, 31);
            this.tbxIndexInsert.TabIndex = 2;
            this.tbxIndexInsert.Visible = false;
            // 
            // btnAddElement
            // 
            this.btnAddElement.Location = new System.Drawing.Point(36, 106);
            this.btnAddElement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(412, 44);
            this.btnAddElement.TabIndex = 1;
            this.btnAddElement.Text = "Element anhängen";
            this.btnAddElement.UseVisualStyleBackColor = true;
            // 
            // tbxNewContent
            // 
            this.tbxNewContent.Location = new System.Drawing.Point(36, 42);
            this.tbxNewContent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxNewContent.Name = "tbxNewContent";
            this.tbxNewContent.Size = new System.Drawing.Size(408, 31);
            this.tbxNewContent.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelFirst);
            this.groupBox2.Controls.Add(this.btnDelLast);
            this.groupBox2.Controls.Add(this.btnDelOnIndex);
            this.groupBox2.Controls.Add(this.tbxIndexDel);
            this.groupBox2.Controls.Add(this.btnDelOnContent);
            this.groupBox2.Controls.Add(this.tbxContentDel);
            this.groupBox2.Location = new System.Drawing.Point(544, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(626, 267);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemente löschen";
            this.groupBox2.Visible = false;
            // 
            // btnDelFirst
            // 
            this.btnDelFirst.Location = new System.Drawing.Point(36, 38);
            this.btnDelFirst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelFirst.Name = "btnDelFirst";
            this.btnDelFirst.Size = new System.Drawing.Size(260, 44);
            this.btnDelFirst.TabIndex = 5;
            this.btnDelFirst.Text = "erstes Elem. löschen";
            this.btnDelFirst.UseVisualStyleBackColor = true;
            // 
            // btnDelLast
            // 
            this.btnDelLast.Location = new System.Drawing.Point(324, 38);
            this.btnDelLast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelLast.Name = "btnDelLast";
            this.btnDelLast.Size = new System.Drawing.Size(260, 44);
            this.btnDelLast.TabIndex = 4;
            this.btnDelLast.Text = "letztes Elem. löschen";
            this.btnDelLast.UseVisualStyleBackColor = true;
            // 
            // btnDelOnIndex
            // 
            this.btnDelOnIndex.Location = new System.Drawing.Point(196, 106);
            this.btnDelOnIndex.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelOnIndex.Name = "btnDelOnIndex";
            this.btnDelOnIndex.Size = new System.Drawing.Size(388, 44);
            this.btnDelOnIndex.TabIndex = 3;
            this.btnDelOnIndex.Text = "Element löschen bei";
            this.btnDelOnIndex.UseVisualStyleBackColor = true;
            // 
            // tbxIndexDel
            // 
            this.tbxIndexDel.Location = new System.Drawing.Point(36, 110);
            this.tbxIndexDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxIndexDel.Name = "tbxIndexDel";
            this.tbxIndexDel.Size = new System.Drawing.Size(144, 31);
            this.tbxIndexDel.TabIndex = 2;
            // 
            // btnDelOnContent
            // 
            this.btnDelOnContent.Location = new System.Drawing.Point(196, 173);
            this.btnDelOnContent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelOnContent.Name = "btnDelOnContent";
            this.btnDelOnContent.Size = new System.Drawing.Size(388, 44);
            this.btnDelOnContent.TabIndex = 1;
            this.btnDelOnContent.Text = "Element mit Inhalt Löschen";
            this.btnDelOnContent.UseVisualStyleBackColor = true;
            // 
            // tbxContentDel
            // 
            this.tbxContentDel.Location = new System.Drawing.Point(36, 177);
            this.tbxContentDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxContentDel.Name = "tbxContentDel";
            this.tbxContentDel.Size = new System.Drawing.Size(144, 31);
            this.tbxContentDel.TabIndex = 0;
            // 
            // tbxAnzElemente
            // 
            this.tbxAnzElemente.Location = new System.Drawing.Point(240, 329);
            this.tbxAnzElemente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxAnzElemente.Name = "tbxAnzElemente";
            this.tbxAnzElemente.Size = new System.Drawing.Size(142, 31);
            this.tbxAnzElemente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "AnzElemente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "erster Inhalt";
            // 
            // tbxFirstElem
            // 
            this.tbxFirstElem.Location = new System.Drawing.Point(592, 329);
            this.tbxFirstElem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxFirstElem.Name = "tbxFirstElem";
            this.tbxFirstElem.Size = new System.Drawing.Size(142, 31);
            this.tbxFirstElem.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "letzter Inhalt";
            // 
            // tbxLastElem
            // 
            this.tbxLastElem.Location = new System.Drawing.Point(934, 329);
            this.tbxLastElem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbxLastElem.Name = "tbxLastElem";
            this.tbxLastElem.Size = new System.Drawing.Size(142, 31);
            this.tbxLastElem.TabIndex = 9;
            // 
            // btnNeueListe
            // 
            this.btnNeueListe.Location = new System.Drawing.Point(1236, 31);
            this.btnNeueListe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNeueListe.Name = "btnNeueListe";
            this.btnNeueListe.Size = new System.Drawing.Size(150, 44);
            this.btnNeueListe.TabIndex = 11;
            this.btnNeueListe.Text = "neue Liste";
            this.btnNeueListe.UseVisualStyleBackColor = true;
            this.btnNeueListe.Click += new System.EventHandler(this.btnNeueListe_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(1236, 87);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(150, 44);
            this.btnClearList.TabIndex = 12;
            this.btnClearList.Text = "Liste leeren";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 504);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnNeueListe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxLastElem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFirstElem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAnzElemente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.tbxCompleteList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Verkettete Liste vom Typ string";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCompleteList;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertElement;
        private System.Windows.Forms.TextBox tbxIndexInsert;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.TextBox tbxNewContent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelLast;
        private System.Windows.Forms.Button btnDelOnIndex;
        private System.Windows.Forms.TextBox tbxIndexDel;
        private System.Windows.Forms.Button btnDelOnContent;
        private System.Windows.Forms.TextBox tbxContentDel;
        private System.Windows.Forms.TextBox tbxAnzElemente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFirstElem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLastElem;
        private System.Windows.Forms.Button btnNeueListe;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnDelFirst;
    }
}

