namespace SaipalStore
{
    partial class homePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topBar = new System.Windows.Forms.Panel();
            this.appMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pnlStore = new System.Windows.Forms.Panel();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.lblCart = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.totalPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountPer = new System.Windows.Forms.Label();
            this.lblTotalAD = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.topBar.SuspendLayout();
            this.appMenu.SuspendLayout();
            this.pnlStore.SuspendLayout();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.container.SuspendLayout();
            this.totalPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.topBar.BackColor = System.Drawing.Color.Black;
            this.topBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topBar.Controls.Add(this.pnlStore);
            this.topBar.Controls.Add(this.appMenu);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.ForeColor = System.Drawing.Color.White;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(971, 37);
            this.topBar.TabIndex = 0;
            // 
            // appMenu
            // 
            this.appMenu.Controls.Add(this.btnMin);
            this.appMenu.Controls.Add(this.btnClose);
            this.appMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.appMenu.Location = new System.Drawing.Point(899, 0);
            this.appMenu.Name = "appMenu";
            this.appMenu.Size = new System.Drawing.Size(70, 35);
            this.appMenu.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(35, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pnlStore
            // 
            this.pnlStore.Controls.Add(this.lblStoreName);
            this.pnlStore.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStore.Location = new System.Drawing.Point(0, 0);
            this.pnlStore.Name = "pnlStore";
            this.pnlStore.Size = new System.Drawing.Size(208, 35);
            this.pnlStore.TabIndex = 1;
            // 
            // lblStoreName
            // 
            this.lblStoreName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStoreName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(27, 4);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(150, 27);
            this.lblStoreName.TabIndex = 1;
            this.lblStoreName.Text = "Saipal Store";
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.panel2);
            this.productsPanel.Controls.Add(this.lblCart);
            this.productsPanel.Controls.Add(this.dgProduct);
            this.productsPanel.Controls.Add(this.panel1);
            this.productsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.productsPanel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsPanel.Location = new System.Drawing.Point(0, 0);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(594, 592);
            this.productsPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(25, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 1);
            this.panel1.TabIndex = 2;
            // 
            // dgProduct
            // 
            this.dgProduct.AllowUserToAddRows = false;
            this.dgProduct.AllowUserToDeleteRows = false;
            this.dgProduct.AllowUserToResizeColumns = false;
            this.dgProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgProduct.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productQuantity,
            this.productRate,
            this.totalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgProduct.GridColor = System.Drawing.Color.Gainsboro;
            this.dgProduct.Location = new System.Drawing.Point(25, 113);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.ReadOnly = true;
            this.dgProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProduct.RowHeadersVisible = false;
            this.dgProduct.Size = new System.Drawing.Size(563, 452);
            this.dgProduct.TabIndex = 3;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.BackColor = System.Drawing.Color.Transparent;
            this.lblCart.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.Black;
            this.lblCart.Location = new System.Drawing.Point(24, 54);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(159, 28);
            this.lblCart.TabIndex = 1;
            this.lblCart.Text = "Shopping Cart";
            // 
            // container
            // 
            this.container.Controls.Add(this.panel7);
            this.container.Controls.Add(this.panel3);
            this.container.Controls.Add(this.topBar);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(971, 639);
            this.container.TabIndex = 0;
            // 
            // totalPanel
            // 
            this.totalPanel.Controls.Add(this.panel8);
            this.totalPanel.Controls.Add(this.lblFinalTotal);
            this.totalPanel.Controls.Add(this.lblTotalAD);
            this.totalPanel.Controls.Add(this.lblDiscountPer);
            this.totalPanel.Controls.Add(this.lblDiscount);
            this.totalPanel.Controls.Add(this.lblAmount);
            this.totalPanel.Controls.Add(this.lblTotalAmount);
            this.totalPanel.Controls.Add(this.panel4);
            this.totalPanel.Controls.Add(this.lblTotal);
            this.totalPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalPanel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPanel.Location = new System.Drawing.Point(594, 390);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new System.Drawing.Size(377, 202);
            this.totalPanel.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(27, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(30, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 28);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.grpButtons);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.panel6);
            this.addPanel.Controls.Add(this.txtRate);
            this.addPanel.Controls.Add(this.panel5);
            this.addPanel.Controls.Add(this.lblRate);
            this.addPanel.Controls.Add(this.txtQuantity);
            this.addPanel.Controls.Add(this.lblQuantity);
            this.addPanel.Controls.Add(this.txtName);
            this.addPanel.Controls.Add(this.lblName);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPanel.Location = new System.Drawing.Point(594, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(377, 390);
            this.addPanel.TabIndex = 10;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtRate.Location = new System.Drawing.Point(164, 206);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(71, 26);
            this.txtRate.TabIndex = 17;
            this.txtRate.Text = "0";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Font = new System.Drawing.Font("Open Sans", 10F);
            this.panel5.Location = new System.Drawing.Point(161, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 1);
            this.panel5.TabIndex = 14;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblRate.Location = new System.Drawing.Point(91, 209);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(39, 19);
            this.lblRate.TabIndex = 11;
            this.lblRate.Text = "Rate";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(164, 156);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(71, 26);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(65, 159);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(67, 19);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Open Sans", 10F);
            this.txtName.Location = new System.Drawing.Point(161, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 19);
            this.txtName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblName.Location = new System.Drawing.Point(31, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 19);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Product";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(17, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 1);
            this.panel6.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(163, 596);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 48);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 629);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.addPanel);
            this.panel7.Controls.Add(this.totalPanel);
            this.panel7.Controls.Add(this.productsPanel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(971, 592);
            this.panel7.TabIndex = 12;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTotalAmount.Location = new System.Drawing.Point(83, 71);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(113, 22);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblAmount.Location = new System.Drawing.Point(262, 71);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 22);
            this.lblAmount.TabIndex = 11;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDiscount.Location = new System.Drawing.Point(83, 105);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(135, 22);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "Special Discount";
            // 
            // lblDiscountPer
            // 
            this.lblDiscountPer.AutoSize = true;
            this.lblDiscountPer.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblDiscountPer.Location = new System.Drawing.Point(262, 105);
            this.lblDiscountPer.Name = "lblDiscountPer";
            this.lblDiscountPer.Size = new System.Drawing.Size(0, 22);
            this.lblDiscountPer.TabIndex = 13;
            // 
            // lblTotalAD
            // 
            this.lblTotalAD.AutoSize = true;
            this.lblTotalAD.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblTotalAD.Location = new System.Drawing.Point(83, 152);
            this.lblTotalAD.Name = "lblTotalAD";
            this.lblTotalAD.Size = new System.Drawing.Size(160, 22);
            this.lblTotalAD.TabIndex = 14;
            this.lblTotalAD.Text = "Total after Discount";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblFinalTotal.Location = new System.Drawing.Point(262, 152);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(0, 22);
            this.lblFinalTotal.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Font = new System.Drawing.Font("Open Sans", 12F);
            this.panel8.Location = new System.Drawing.Point(77, 139);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 1);
            this.panel8.TabIndex = 16;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnClear);
            this.grpButtons.Controls.Add(this.btnTotal);
            this.grpButtons.Controls.Add(this.btnAdd);
            this.grpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpButtons.Location = new System.Drawing.Point(0, 250);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(377, 140);
            this.grpButtons.TabIndex = 20;
            this.grpButtons.TabStop = false;
            // 
            // btnTotal
            // 
            this.btnTotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTotal.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.Black;
            this.btnTotal.Image = ((System.Drawing.Image)(resources.GetObject("btnTotal.Image")));
            this.btnTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotal.Location = new System.Drawing.Point(106, 84);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(91, 41);
            this.btnTotal.TabIndex = 17;
            this.btnTotal.Text = "Total";
            this.btnTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(135, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 41);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add To Cart";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // productName
            // 
            this.productName.FillWeight = 102.7919F;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productQuantity
            // 
            this.productQuantity.FillWeight = 102.7919F;
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            // 
            // productRate
            // 
            this.productRate.FillWeight = 102.7919F;
            this.productRate.HeaderText = "Rate";
            this.productRate.Name = "productRate";
            this.productRate.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.FillWeight = 102.7919F;
            this.totalPrice.HeaderText = "Total";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(220, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 41);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 639);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homePage";
            this.Text = "Saipal Store";
            this.topBar.ResumeLayout(false);
            this.appMenu.ResumeLayout(false);
            this.pnlStore.ResumeLayout(false);
            this.pnlStore.PerformLayout();
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.container.ResumeLayout(false);
            this.totalPanel.ResumeLayout(false);
            this.totalPanel.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Panel pnlStore;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Panel appMenu;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel totalPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblTotalAD;
        private System.Windows.Forms.Label lblDiscountPer;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgProduct;
    }
}

