using System;
using System.IO;
using System.Xml;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace Belayab
{
	/// <summary>
	/// Summary description for clsXmlAccess.
	/// </summary>
	public class clsXmlAccess
	{
		System.Windows.Forms.Form frmToLoad;
		public static string strAppPath="";
		
		public clsXmlAccess(System.Windows.Forms.Form frm)
		{
			//
			// TODO: Add constructor logic here
			//
			if(strAppPath.Equals(""))
				strAppPath=new DirectoryInfo("xmlFiles").Parent.FullName;
			frmToLoad=frm;
			formsLoad(frm);
		}


		private void formsLoad(System.Windows.Forms.Form frm)
		{
			// Makes sure Windows XP is running and 
			//  a .manifest file exists for the EXE.
			if(Environment.OSVersion.Version.Major > 4 
				& Environment.OSVersion.Version.Minor > 0 
				& System.IO.File.Exists(Application.ExecutablePath + ".manifest"))
			{ 
				// Iterate through the controls.
				for(int x = 0; x < frm.Controls.Count; x++)
				{
					// If the control derives from ButtonBase,
					// set its FlatStyle property to FlatStyle.System.
					if(frm.Controls[x].GetType().BaseType == typeof(ButtonBase))
					{
						((ButtonBase)frm.Controls[x]).FlatStyle = FlatStyle.System; 
					}
					RecursivelyFormatForWinXP(frm.Controls[x]);
				}
			}
		}
		private void RecursivelyFormatForWinXP(Control control)
		{
			for(int x = 0; x < control.Controls.Count; x++)
			{
				// If the control derives from ButtonBase, 
				//  set its FlatStyle property to FlatStyle.System.
				if(control.Controls[x].GetType().BaseType == typeof(ButtonBase))
				{
					((ButtonBase)control.Controls[x]).FlatStyle = FlatStyle.System; 
				}
  
				// If the control holds other controls, iterate through them also.
				if(control.Controls.Count > 0)
				{
					RecursivelyFormatForWinXP(control.Controls[x]);
				}
			}
		}

		public clsXmlAccess()
		{
			//
			// TODO: Add constructor logic here
			//
			if(strAppPath.Equals(""))
				strAppPath=new DirectoryInfo("xmlFiles").Parent.FullName;
		
		}
		

		public  void readXmlFile(string strLang,string strSrcFile)
		{
			XmlTextReader readerNode = null;
			int intFirstIndex=-1,intSeconIndex=-1,intThirdIndex=-1,intFourthIndex=-1;
			int intControlType=-1;
			string strControlName="",strParentControlName="";
			System.Windows.Forms.ListView lvTemp;
			System.Windows.Forms.TreeView tvTemp;
			System.Windows.Forms.ToolBar tlbTemp;
			System.Windows.Forms.TabControl tabTemp;

			try
			{
				// gets the XML data.
				
				readerNode = new XmlTextReader(strAppPath+"\\xmlFiles\\"+strSrcFile);
				//Read the first name attribute.
				
				while (readerNode.Read())
				{
					if(readerNode.Name.StartsWith("lv") || readerNode.Name.StartsWith("tlb")
						||readerNode.Name.StartsWith("tab")||readerNode.Name.StartsWith("tv"))
						strParentControlName=readerNode.Name;

					if(readerNode.NodeType==XmlNodeType.Element 
						&& !readerNode.Name.StartsWith("lv") && !readerNode.Name.StartsWith("tab")
						&& !readerNode.Name.StartsWith("frm")&& !readerNode.Name.StartsWith("tv"))
					{
						strControlName=readerNode.Name;
						
						getControlIndex(strControlName,strParentControlName,ref intControlType,ref intFirstIndex,ref intSeconIndex,ref intThirdIndex, ref intFourthIndex);
						if(intFirstIndex!=-1 || intSeconIndex!=-1)//there could be a control with no entry in the xml file
						{
							if(intControlType==1)
								frmToLoad.Controls[intFirstIndex].Controls[intSeconIndex].Text=readerNode[strLang];
							else if(intControlType==2)
							{
								lvTemp=(System.Windows.Forms.ListView)frmToLoad.Controls[intFirstIndex];
								lvTemp.Columns[intSeconIndex].Text=readerNode[strLang];
							}
							else if(intControlType==3)
							{
								tlbTemp=(System.Windows.Forms.ToolBar)frmToLoad.Controls[intFirstIndex];
								tlbTemp.Buttons[intSeconIndex].Text=readerNode[strLang];
							}
							else if(intControlType==4)
							{
								if(intFourthIndex!=-1)
								{
									tabTemp=(System.Windows.Forms.TabControl)frmToLoad.Controls[intFirstIndex];
									tabTemp.TabPages[intSeconIndex].Controls[intThirdIndex].Controls[intFourthIndex].Text=readerNode[strLang];
								}
								else if(intThirdIndex!=-1)
								{
									tabTemp=(System.Windows.Forms.TabControl)frmToLoad.Controls[intFirstIndex];
									tabTemp.TabPages[intSeconIndex].Controls[intThirdIndex].Text=readerNode[strLang];
								}
								else// if(intFourthIndex!=-1)
								{
									tabTemp=(System.Windows.Forms.TabControl)frmToLoad.Controls[intFirstIndex];
									tabTemp.TabPages[intSeconIndex].Text=readerNode[strLang];
								}

							}
							else if(intControlType==5)
							{
								tvTemp=(System.Windows.Forms.TreeView)frmToLoad.Controls[intFirstIndex];
								tvTemp.Nodes[0].Nodes[intSeconIndex].Text=readerNode[strLang];
							}
							else if(intControlType==6)
							{
								frmToLoad.Controls[intFirstIndex].Controls[intSeconIndex].Controls[intThirdIndex].Text=readerNode[strLang];
							}
							else
								frmToLoad.Controls[intFirstIndex].Text=readerNode[strLang];
						}
					}

					

				}


			} 

			finally 
			{
				if (readerNode != null)
					readerNode.Close();
			}
		}

		private void getControlIndex(string strControlName,string strParentControlName, ref int intControlType/*1=gropubox, 2=listview, 0=others*/,ref int intFirstIndex,ref int intSecondIndex,ref int intThirdIndex,ref int intFourthIndex)
		{
			intFirstIndex=-1;
			intSecondIndex=-1;
			intThirdIndex=-1;
			intFourthIndex=-1;
			intControlType=-1;

			System.Windows.Forms.ListView lvTemp;
			System.Windows.Forms.TreeView tvTemp;
			System.Windows.Forms.ToolBar tlbTemp;
			System.Windows.Forms.TabControl tabTemp;

			for (int i=0;i<frmToLoad.Controls.Count;i++)
			{
				if(frmToLoad.Controls[i].Name.StartsWith("grp") || frmToLoad.Controls[i].Name.StartsWith("pnl") )
				{
					
					if(frmToLoad.Controls[i].Name.Equals(strControlName))
					{
						intFirstIndex=i;
						intSecondIndex=-1;
						intControlType=0;
						return ;
					}

					for (int j=0;j<frmToLoad.Controls[i].Controls.Count;j++)
					{
						if(frmToLoad.Controls[i].Controls[j].Name.Equals(strControlName))
						{
							intFirstIndex=i;
							intSecondIndex=j;
							intControlType=1;
							return ;
						}
						else if(frmToLoad.Controls[i].Controls[j].Name.StartsWith("grp") || frmToLoad.Controls[i].Controls[j].Name.StartsWith("pnl") )
						{
							for (int k=0;k<frmToLoad.Controls[i].Controls[j].Controls.Count;k++)
							{
								if(frmToLoad.Controls[i].Controls[j].Controls[k].Name.Equals(strControlName))
								{
									intFirstIndex=i;
									intSecondIndex=j;
									intThirdIndex = k;
									intControlType=6;
									return ;
								}
							}
						}
					}

				}
				else if(frmToLoad.Controls[i].Name.StartsWith("lv") 
					&& strControlName.StartsWith("colLv"))
				{
					lvTemp=(System.Windows.Forms.ListView)frmToLoad.Controls[i];

					if(lvTemp.Name.Equals(strParentControlName))
					{
						for (int j=0;j<lvTemp.Columns.Count;j++)
							if(strControlName.Substring(5).Equals(""+j))
							{
								intFirstIndex=i;
								intSecondIndex=j;
								intControlType=2;
								return;
							}
					}

				}


				else if(frmToLoad.Controls[i].Name.StartsWith("tlb") 
					&& strControlName.StartsWith("btnTlb"))
				{
					tlbTemp=(System.Windows.Forms.ToolBar)frmToLoad.Controls[i];

					if(tlbTemp.Name.Equals(strParentControlName))
					{
						for (int j=0;j<tlbTemp.Buttons.Count;j++)
							if(strControlName.Substring(6).Equals(""+j))
							{
								intFirstIndex=i;
								intSecondIndex=j;
								intControlType=3;
								return;
							}
					}

				}
				else if(frmToLoad.Controls[i].Name.StartsWith("tab"))
					//&& strControlName.StartsWith("btnTab"))
				{
					tabTemp=(System.Windows.Forms.TabControl)frmToLoad.Controls[i];

					if(tabTemp.Name.Equals(strParentControlName))
					{
						for (int j=0;j<tabTemp.TabPages.Count;j++)
						{
							//the tabpages
							if(strControlName.Substring(6).Equals(""+j))
							{
								intFirstIndex=i;
								intSecondIndex=j;
								intThirdIndex=-1;
								intFourthIndex=-1;
								intControlType=4;
								return;
							}
							//controls in each tab
							for (int k=0;k<tabTemp.TabPages[j].Controls.Count;k++)
							{
								//groupbox
								if(tabTemp.TabPages[j].Controls[k].Name.StartsWith("grp"))
								{
									//the groupbox label
									if(tabTemp.TabPages[j].Controls[k].Name.Equals(strControlName))
									{
										intFirstIndex=i;
										intSecondIndex=j;
										intThirdIndex=k;
										intFourthIndex=-1;
										intControlType=4;
										return ;
									}
									//the groupbox controls label
									for (int l=0;l<tabTemp.TabPages[j].Controls[k].Controls.Count;l++)
										if(tabTemp.TabPages[j].Controls[k].Controls[l].Name.Equals(strControlName))
										{
											intFirstIndex=i;
											intSecondIndex=j;
											intThirdIndex=k;
											intFourthIndex=l;
											intControlType=4;

											return;
										}
										
									
								}

									//other than group box
								else
								{
									if(tabTemp.TabPages[j].Controls[k].Name.Equals(strControlName))
									{
										intFirstIndex=i;
										intSecondIndex=j;
										intThirdIndex=k;
										intFourthIndex=-1;
										intControlType=4;
										return ;
									}
								}

							}

						}
					}
									
				}
				else if(frmToLoad.Controls[i].Name.StartsWith("tv") 
					&& strControlName.StartsWith("nodeTv"))
				{
					tvTemp=(System.Windows.Forms.TreeView)frmToLoad.Controls[i];

					if(tvTemp.Name.Equals(strParentControlName))
					{
						for (int j=0;j<tvTemp.Nodes[0].Nodes.Count;j++)
							if(strControlName.Substring(6).Equals(""+j))
							{
								intFirstIndex=i;
								intSecondIndex=j;
								intControlType=5;
								return;
							}
					}

				}
					//any other control than groupbox and listview
				else
				{
					if(frmToLoad.Controls[i].Name.Equals(strControlName))
					{
						intFirstIndex=i;
						intSecondIndex=-1;
						intControlType=0;
						return ;
					}
				}
					
				

			}

			
		}


		// for reports
		
		public  void readReportXmlFile(string strLang,ReportDocument rptDoc,string strRptName)
		{
			XmlTextReader readerNode = null;
			TextObject txtObject;
			string strReportName=strRptName;//getReportName(rptDoc.FilePath);
						
			try
			{
				// gets the XML data.
				readerNode = new XmlTextReader(strAppPath+"\\xmlFiles\\xmlReports.xml");
				
				//read labels
				while (readerNode.Read())
				{
					if(readerNode.Name.Equals(strReportName) ) 
					{
						
						while (readerNode.Read())
						{
							if(readerNode.NodeType==XmlNodeType.EndElement && readerNode.Name.Equals(strReportName) )
								return;

							if(readerNode.NodeType==XmlNodeType.Element )
							{
								txtObject= rptDoc.ReportDefinition.ReportObjects[readerNode.Name] as TextObject;
								txtObject.Text=readerNode[strLang];
							}
						
						}
					}
				

				}


			}

			finally 
			{
				if (readerNode != null)
					readerNode.Close();
			}
		}

		public  string readWord(string strLang,string strCriteria)
		{
			XmlTextReader readerNode = null;
						
			try
			{
				// gets the XML data.
				readerNode = new XmlTextReader(strAppPath+"\\xmlFiles\\xmlDifferent.xml");
				//read words
				while (readerNode.Read())
				{
							
					if(readerNode.NodeType==XmlNodeType.Element && strCriteria.Equals(readerNode.Name) )
						return readerNode[strLang];
					
					
				}

				return "";

			}

			finally 
			{
				if (readerNode != null)
					readerNode.Close();
			}
		}

		private string getReportName(string strReportFileName)
		{
			string strReversed="";
			if(strReportFileName.Trim().Equals(""))
				return "";
			for(int i=strReportFileName.Length-1;i>=0;i--)
			{
				if(!strReportFileName[i].ToString().Equals("\\"))
					strReversed=strReversed+strReportFileName[i];
				else
					break;	
					
			}
			
			string strReportName="";
			for(int i=strReversed.Length-1;i>=0;i--)
			{
				if(!strReversed[i].ToString().Equals("."))
					strReportName=strReportName+strReversed[i];
				else
					break;	
			
			}
			
			return strReportName;
		}
	

	}
}
