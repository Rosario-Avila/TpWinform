﻿namespace TPWinForm
{
    partial class AddArticleFom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArticleFom));
            this.ArticleCode = new System.Windows.Forms.Label();
            this.txtArticleCode = new System.Windows.Forms.TextBox();
            this.txtArticleName = new System.Windows.Forms.TextBox();
            this.ArticleName = new System.Windows.Forms.Label();
            this.txtArticleDescription = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.txtArticlePrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pbxImages = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelAddArticle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrlImage = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticleCode
            // 
            resources.ApplyResources(this.ArticleCode, "ArticleCode");
            this.ArticleCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.ArticleCode.Name = "ArticleCode";
            // 
            // txtArticleCode
            // 
            resources.ApplyResources(this.txtArticleCode, "txtArticleCode");
            this.txtArticleCode.Name = "txtArticleCode";
            // 
            // txtArticleName
            // 
            resources.ApplyResources(this.txtArticleName, "txtArticleName");
            this.txtArticleName.Name = "txtArticleName";
            // 
            // ArticleName
            // 
            resources.ApplyResources(this.ArticleName, "ArticleName");
            this.ArticleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.ArticleName.Name = "ArticleName";
            // 
            // txtArticleDescription
            // 
            resources.ApplyResources(this.txtArticleDescription, "txtArticleDescription");
            this.txtArticleDescription.Name = "txtArticleDescription";
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.Description.Name = "Description";
            // 
            // labelBrand
            // 
            resources.ApplyResources(this.labelBrand, "labelBrand");
            this.labelBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.labelBrand.Name = "labelBrand";
            // 
            // labelImage
            // 
            resources.ApplyResources(this.labelImage, "labelImage");
            this.labelImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.labelImage.Name = "labelImage";
            // 
            // cboBrand
            // 
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            resources.ApplyResources(this.cboBrand, "cboBrand");
            this.cboBrand.Name = "cboBrand";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            resources.ApplyResources(this.cboCategory, "cboCategory");
            this.cboCategory.Name = "cboCategory";
            // 
            // labelCategory
            // 
            resources.ApplyResources(this.labelCategory, "labelCategory");
            this.labelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.labelCategory.Name = "labelCategory";
            // 
            // txtArticlePrice
            // 
            resources.ApplyResources(this.txtArticlePrice, "txtArticlePrice");
            this.txtArticlePrice.Name = "txtArticlePrice";
            // 
            // labelPrice
            // 
            resources.ApplyResources(this.labelPrice, "labelPrice");
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.labelPrice.Name = "labelPrice";
            // 
            // pbxImages
            // 
            this.pbxImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.pbxImages, "pbxImages");
            this.pbxImages.Name = "pbxImages";
            this.pbxImages.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelAddArticle
            // 
            this.btnCancelAddArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(187)))));
            resources.ApplyResources(this.btnCancelAddArticle, "btnCancelAddArticle");
            this.btnCancelAddArticle.Name = "btnCancelAddArticle";
            this.btnCancelAddArticle.UseVisualStyleBackColor = false;
            this.btnCancelAddArticle.Click += new System.EventHandler(this.btnCancellAddArticle);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.label1.Name = "label1";
            // 
            // txtUrlImage
            // 
            resources.ApplyResources(this.txtUrlImage, "txtUrlImage");
            this.txtUrlImage.Name = "txtUrlImage";
            this.txtUrlImage.Leave += new System.EventHandler(this.txtUrlImage_Leave);
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            resources.ApplyResources(this.btnAddImage, "btnAddImage");
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // AddArticleFom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(195)))), ((int)(((byte)(161)))));
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.txtUrlImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelAddArticle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbxImages);
            this.Controls.Add(this.txtArticlePrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.cboBrand);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.txtArticleDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.txtArticleName);
            this.Controls.Add(this.ArticleName);
            this.Controls.Add(this.txtArticleCode);
            this.Controls.Add(this.ArticleCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddArticleFom";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArticleCode;
        private System.Windows.Forms.TextBox txtArticleCode;
        private System.Windows.Forms.TextBox txtArticleName;
        private System.Windows.Forms.Label ArticleName;
        private System.Windows.Forms.TextBox txtArticleDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox txtArticlePrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pbxImages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelAddArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrlImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}