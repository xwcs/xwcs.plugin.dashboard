namespace xwcs.plugin.dashboard
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openWidgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
			this.widgetView1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(this.components);
			this.rowDefinition1 = new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition();
			this.rowDefinition2 = new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition();
			this.rowDefinition3 = new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition();
			this.columnDefinition1 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
			this.columnDefinition2 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
			this.columnDefinition3 = new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.widgetView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rowDefinition1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rowDefinition2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rowDefinition3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnDefinition1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnDefinition2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnDefinition3)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWidgetsToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(148, 26);
			// 
			// openWidgetsToolStripMenuItem
			// 
			this.openWidgetsToolStripMenuItem.Name = "openWidgetsToolStripMenuItem";
			this.openWidgetsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.openWidgetsToolStripMenuItem.Text = "Open widgets";
			this.openWidgetsToolStripMenuItem.Click += new System.EventHandler(this.openWidgetsToolStripMenuItem_Click);
			// 
			// documentManager1
			// 
			this.documentManager1.ContainerControl = this;
			this.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
			this.documentManager1.View = this.widgetView1;
			this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.widgetView1});
			// 
			// widgetView1
			// 
			this.widgetView1.Columns.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition[] {
            this.columnDefinition1,
            this.columnDefinition2,
            this.columnDefinition3});
			this.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.TableLayout;
			this.widgetView1.Rows.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition[] {
            this.rowDefinition1,
            this.rowDefinition2,
            this.rowDefinition3});
			// 
			// DashboardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Name = "DashboardControl";
			this.Size = new System.Drawing.Size(687, 461);
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.widgetView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rowDefinition1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rowDefinition2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rowDefinition3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnDefinition1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnDefinition2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnDefinition3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openWidgetsToolStripMenuItem;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView widgetView1;
		private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition1;
		private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition2;
		private DevExpress.XtraBars.Docking2010.Views.Widget.ColumnDefinition columnDefinition3;
		private DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition rowDefinition1;
		private DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition rowDefinition2;
		private DevExpress.XtraBars.Docking2010.Views.Widget.RowDefinition rowDefinition3;
	}
}
