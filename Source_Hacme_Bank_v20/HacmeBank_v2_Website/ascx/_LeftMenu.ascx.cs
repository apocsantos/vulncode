namespace HacmeBank_v2_Website.ascx
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Summary description for LeftMenu.
	/// </summary>
	public class LeftMenu : System.Web.UI.UserControl
	{
		protected System.Web.UI.WebControls.LinkButton lnkBtnFundsTransfer;
		protected System.Web.UI.WebControls.LinkButton lnkBtnPostMessage;
		protected System.Web.UI.WebControls.LinkButton lnkBtnLoans;	
		protected System.Web.UI.WebControls.LinkButton lnkBtnAdminSection;		

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		///		Required method for Designer support - do not modify
		///		the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		//		This method links to Loan.aspx form.

		protected void lnkBtnLoans_Click(object sender, System.EventArgs e)
		{
			Response.Redirect ("main.aspx?function=Loan");
		}

		//		This method links to PostMessageForm.aspx form.
		protected void lnkBtnPostMessage_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("main.aspx?function=PostMessageForm");
		}

		//		This method links to AccountTransfer.aspx form.

		protected void lnkBtnFundsTransfer_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("main.aspx?function=AccountTransfer");
		}

		protected void lnkBtnAdminSection_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("main.aspx?function=AdminSection");
		}		
	}
}
