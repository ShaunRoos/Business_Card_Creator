using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace PDF_Creator_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntSavePdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { FileName = comboBox1.Text + ".pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Rectangle bussinessCard = new iTextSharp.text.Rectangle(241, 156);

                    Document doc = new Document(PageSize.A7);
                    doc.SetMargins(14.2f, 0, 0, 0);
                    //doc.SetMargins(14.5f, 14, 0, 0);
                    doc.SetPageSize(bussinessCard);
                    iTextSharp.text.Font font_01 = FontFactory.GetFont("C:\\Windows\\Fonts\\Gill Sans.ttf", 9, BaseColor.BLACK);
                    font_01.BaseFont.IsEmbedded();
                    iTextSharp.text.Font font_02 = FontFactory.GetFont("C:\\Windows\\Fonts\\Gill Sans.ttf", 7, BaseColor.BLACK);
                    font_02.BaseFont.IsEmbedded();
                    iTextSharp.text.Font font_03 = FontFactory.GetFont("C:\\Windows\\Fonts\\Gnl____.ttf", 7, BaseColor.BLACK);
                    font_03.BaseFont.IsEmbedded();
                    iTextSharp.text.Font font_04 = FontFactory.GetFont("C:\\Windows\\Fonts\\Gnl____.ttf", 5, BaseColor.BLACK);
                    font_04.BaseFont.IsEmbedded();
                    iTextSharp.text.Chunk C00 = new iTextSharp.text.Chunk(" ", font_01);
                    iTextSharp.text.Chunk C01 = new iTextSharp.text.Chunk(tbName.Text + " ", font_01);
                    iTextSharp.text.Chunk C02 = new iTextSharp.text.Chunk(tbTitle.Text + " ", font_02);
                    iTextSharp.text.Chunk C03 = new iTextSharp.text.Chunk(tbQuaifications.Text + " ", font_02);
                    iTextSharp.text.Chunk C04 = new iTextSharp.text.Chunk(tbTelephone.Text + " ", font_03);
                    iTextSharp.text.Chunk C05 = new iTextSharp.text.Chunk(tbMobile.Text + " ", font_03);
                    iTextSharp.text.Chunk C06 = new iTextSharp.text.Chunk(tbEmail.Text + " ", font_03);
                    iTextSharp.text.Chunk C07 = new iTextSharp.text.Chunk(tbComName.Text, font_04);
                    iTextSharp.text.Chunk C08 = new iTextSharp.text.Chunk(tbRegNo.Text, font_04);
                    iTextSharp.text.Chunk C09 = new iTextSharp.text.Chunk(tbOffice.Text, font_03);
                    iTextSharp.text.Chunk C10 = new iTextSharp.text.Chunk(tbStreet.Text, font_03);
                    iTextSharp.text.Chunk C11 = new iTextSharp.text.Chunk(tbArea.Text, font_03);
                    iTextSharp.text.Chunk C12 = new iTextSharp.text.Chunk(tbRegion.Text, font_03);
                    iTextSharp.text.Chunk C13 = new iTextSharp.text.Chunk(tbPostalCode.Text, font_03);
                    iTextSharp.text.Chunk C14 = new iTextSharp.text.Chunk(tbWeb.Text, font_03);

                    Paragraph pa00 = new iTextSharp.text.Paragraph();
                    pa00.Add(C00);
                    Paragraph pa01 = new iTextSharp.text.Paragraph();
                    pa01.Add(C01);                                       
                    pa01.SpacingBefore = 37.5f;
                    Paragraph pa02 = new iTextSharp.text.Paragraph();
                    pa02.Add(C02);
                    pa02.SpacingBefore = -7f;
                    Paragraph pa03 = new iTextSharp.text.Paragraph();
                    pa03.Add(C03);
                    pa03.SpacingBefore = -7f;
                    Paragraph pa04 = new iTextSharp.text.Paragraph();
                    pa04.Add(C04);
                    pa04.SpacingBefore = 1.6f;
                    Paragraph pa05 = new iTextSharp.text.Paragraph();
                    pa05.Add(C05);
                    pa05.SpacingBefore = -6.9f;
                    Paragraph pa06 = new iTextSharp.text.Paragraph();
                    pa06.Add(C06);
                    pa06.SpacingBefore = -6.9f;
                    Paragraph pa07 = new iTextSharp.text.Paragraph();
                    pa07.Add(C07);
                    pa07.SpacingBefore = -3f;
                    Paragraph pa08 = new iTextSharp.text.Paragraph();
                    pa08.Add(C08);
                    pa08.SpacingBefore = 11f;
                    Paragraph pa09 = new iTextSharp.text.Paragraph();
                    pa09.Add(C09);
                    pa09.SpacingBefore = -74f;
                    pa09.IndentationLeft = 127f;
                    Paragraph pa10 = new iTextSharp.text.Paragraph();
                    pa10.Add(C10);
                    pa10.SpacingBefore = -7f;
                    pa10.IndentationLeft = 127f;
                    Paragraph pa11 = new iTextSharp.text.Paragraph();
                    pa11.Add(C11);
                    pa11.IndentationLeft = 127f;
                    pa11.SpacingBefore = -7f;
                    Paragraph pa12 = new iTextSharp.text.Paragraph();
                    pa12.Add(C12);
                    pa12.IndentationLeft = 127f;
                    pa12.SpacingBefore = -7f;
                    Paragraph pa13 = new iTextSharp.text.Paragraph();
                    pa13.Add(C13);
                    pa13.IndentationLeft = 127f;
                    pa13.SpacingBefore = -7f;
                    Paragraph pa14 = new iTextSharp.text.Paragraph();
                    pa14.Add(C14);
                    pa14.IndentationLeft = 127f;
                    pa14.SpacingBefore = 11f;
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("Logo.jpg");
                    logo.Alignment = iTextSharp.text.Image.UNDERLYING;
                    logo.ScaleAbsolute(241, 156);
                    logo.SetAbsolutePosition(0, 0);







                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        if(checkBox1.Checked)
                        {
                            doc.Add(logo);
                        }
                        //doc.Add(logo);
                        
                        doc.Add(pa00);
                        doc.Add(pa01);
                        doc.Add(pa02);
                        doc.Add(pa03);
                        doc.Add(pa04);
                        doc.Add(pa05);
                        doc.Add(pa06);
                        doc.Add(pa07);
                        //doc.Add(pa08);
                        doc.Add(pa09);
                        doc.Add(pa10);
                        doc.Add(pa11);
                        doc.Add(pa12);
                        doc.Add(pa13);
                        doc.Add(pa08);
                        //doc.Add(logo);


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Constantia")
            {
                tbComName.Text = "Before the Wind Investments 209 (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2006/0111108/07";
                tbOffice.Text = "Fine & Country Constantia";
                tbStreet.Text = "Shop 8 Old Village";
                tbArea.Text = "Constantia Village Centre";
                tbRegion.Text = "Constantia, Western Cape";
                tbPostalCode.Text = "7806";
            }
            else if (comboBox1.Text == "Camps Bay")
            {
                tbComName.Text = "Before the Wind Investments 209 (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2006/0111108/07";
                tbOffice.Text = "F&C Atlantic Seaboard";
                tbStreet.Text = "Shop 1 Central Parade";
                tbArea.Text = "89 Victoria Road, Camps Bay";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "8005";
            }
            else if (comboBox1.Text == "Fourways")
            {
                tbComName.Text = "Mander Real Estates CC";
                tbRegNo.Text = "Reg No: 2011/094053/23";
                tbOffice.Text = "Fine & Country Fourways";
                tbStreet.Text = "Block D, Lonehill Office Park";
                tbArea.Text = "4 Lone Close, Lonehill";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "2062";
            }
            else if (comboBox1.Text == "Bloemfontein")
            {
                tbComName.Text = "Amber Day Properties (Pty) Ltd";
                tbRegNo.Text = "Reg No:  2012/107249/07";
                tbOffice.Text = "Fine & Country Bloemfontein";
                tbStreet.Text = "83 Gen Dan Pienaar Drive";
                tbArea.Text = "Dan Pienaar, Bloemfontein";
                tbRegion.Text = "Free State";
                tbPostalCode.Text = "9301";
            }
            else if (comboBox1.Text == "Sandton")
            {
                tbComName.Text = "Linda Erasmus Property Enterprises (Pty) Ltd";
                tbRegNo.Text = "Reg No: 1996/018256/07";
                tbOffice.Text = "Fine & Country Sandton";
                tbStreet.Text = "29 Autumn Road";
                tbArea.Text = "Rivonia, Sandton";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "2191";
            }
            else if (comboBox1.Text == "Randburg")
            {
                tbComName.Text = "Gaylin Estate Agents (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2006/002760/07";
                tbOffice.Text = "Fine & Country Randburg";
                tbStreet.Text = "341 Beyers Naude Drive";
                tbArea.Text = "Northcliff, Randburg";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "2194";
            }
            else if (comboBox1.Text == "Linksfield")
            {
                tbComName.Text = "Springtrade 155 CC";
                tbRegNo.Text = "Reg No: 2001/014140/23";
                tbOffice.Text = "Fine & Country Linksfield";
                tbStreet.Text = "9 Rosemary Road";
                tbArea.Text = "Sunningdale";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "2192";
            }
            else if (comboBox1.Text == "Pretoria East")
            {
                tbComName.Text = "Care Properties (Pty) Ltd ";
                tbRegNo.Text = "Reg. No: 1997/18477/07";
                tbOffice.Text = "Fine & Country Pretoria East";
                tbStreet.Text = "598 Rubenstein Drive";
                tbArea.Text = "Moreleta Park";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "0044";
            }
            else if (comboBox1.Text == "Midrand")
            {
                tbComName.Text = "Tradelink Property (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2015/312290/07";
                tbOffice.Text = "Fine & Country Midrand";
                tbStreet.Text = "40 Summerset, Garden Road";
                tbArea.Text = "Summerset, Midrand";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "1685";
            }
            else if (comboBox1.Text == "Kempton Park")
            {
                tbComName.Text = "Kameleon Properties CC";
                tbRegNo.Text = "Reg No: 2005/003943/23";
                tbOffice.Text = "Fine & Country Kempton Park";
                tbStreet.Text = "90 Monument Road";
                tbArea.Text = "Nimrod Park, Kempton Park";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "1619";
            }
            else if (comboBox1.Text == "Edenvale")
            {
                tbComName.Text = "Scenic Route Trading 398 CC";
                tbRegNo.Text = "Reg No: 2005/007076/23";
                tbOffice.Text = "Fine & Country Edenvale";
                tbStreet.Text = "3rd Floor";
                tbArea.Text = "157 Van Riebeeck Ave";
                tbRegion.Text = "Edenvale, Gauteng";
                tbPostalCode.Text = "1609";
            }
            else if (comboBox1.Text == "Alberton")
            {
                tbComName.Text = "GMT Distributors CC";
                tbRegNo.Text = "Reg No: 2000/021205/23";
                tbOffice.Text = "Fine & Country Alberton";
                tbStreet.Text = "101 Vermoonten Street";
                tbArea.Text = "Brackenhurst, Alberton";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "1448";
            }
            else if (comboBox1.Text == "Polokwane")
            {
                tbComName.Text = "Ansie Marais Eiendomme/Estates";
                tbRegNo.Text = "VAT no: 4960220897";
                tbOffice.Text = "Fine & Country Polokwane";
                tbStreet.Text = "Macadamia, The Aloes";
                tbArea.Text = "Aloes Street, Bendor Park";
                tbRegion.Text = "Polokwane";
                tbPostalCode.Text = "0713";
            }
            else if (comboBox1.Text == "Hoedspruit")
            {
                tbComName.Text = "Hoedspruit Fine and Country (PTY) Ltd";
                tbRegNo.Text = "Reg No: 2015/236175/07";
                tbOffice.Text = "Fine & Country Hoedspruit";
                tbStreet.Text = "Shop8, Rhino Convention Ctr";
                tbArea.Text = "Hoedspruit Wildlife Estate";
                tbRegion.Text = "Hoedspruit, Limpopo";
                tbPostalCode.Text = "1380";
            }
            else if (comboBox1.Text == "Malalane")
            {
                tbComName.Text = "Mindmatters Real Estate CC";
                tbRegNo.Text = "Reg No: 2005/096680/23";
                tbOffice.Text = "Fine & Country Malalane";
                tbStreet.Text = "16 Air Street";
                tbArea.Text = "Malalane";
                tbRegion.Text = "Mpumalanga";
                tbPostalCode.Text = "1320";
            }
            else if (comboBox1.Text == "Nelspruit")
            {
                tbComName.Text = "Mindmatters Real Estate CC";
                tbRegNo.Text = "Reg No: 2005/096680/23";
                tbOffice.Text = "Fine & Country Nelspruit";
                tbStreet.Text = "Shop 93, Building 12";
                tbArea.Text = "Crn Le Roux and Faurie Str";
                tbRegion.Text = "Sonpark Boulevard, Nelspruit";
                tbPostalCode.Text = "1200";
            }
            else if (comboBox1.Text == "Marloth Park")
            {
                tbComName.Text = "Mindmatters Real Estate CC";
                tbRegNo.Text = "Reg No: 2005/096680/23";
                tbOffice.Text = "Fine & Country Marloth Park";
                tbStreet.Text = "Wildlife Estate Offices";
                tbArea.Text = "Olifant Ave 3882, Marloth Park";
                tbRegion.Text = "Mpumalanga";
                tbPostalCode.Text = "1340";
            }
            else if (comboBox1.Text == "Komatipoort")
            {
                tbComName.Text = "Mindmatters Real Estate CC";
                tbRegNo.Text = "Reg No: 2005/096680/23";
                tbOffice.Text = "Fine & Country Komatipoort";
                tbStreet.Text = "Komati Square, Shop 21";
                tbArea.Text = "Rissik Street, Komatipoort";
                tbRegion.Text = "Mpumalanga";
                tbPostalCode.Text = "1340";
            }
            else if (comboBox1.Text == "White River")
            {
                tbComName.Text = "Engivect CC";
                tbRegNo.Text = "Reg No: 2011/104517/23";
                tbOffice.Text = "Fine & Country White River";
                tbStreet.Text = "2 Joe Hanna Street";
                tbArea.Text = "White River";
                tbRegion.Text = "Mpumalanga";
                tbPostalCode.Text = "1240";
            }
            else if (comboBox1.Text == "Bethlehem")
            {
                tbComName.Text = "Shell Case 101 (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2005/004454/07";
                tbOffice.Text = "Fine & Country Bethlehem";
                tbStreet.Text = "10 Baartman Street";
                tbArea.Text = "Bethlehem";
                tbRegion.Text = "Freestate";
                tbPostalCode.Text = "9700";
            }
            else if (comboBox1.Text == "Clarens")
            {
                tbComName.Text = "Shell Case 101 (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2005/004454/07";
                tbOffice.Text = "Fine & Country Clarens";
                tbStreet.Text = "322 Van Zyl Street";
                tbArea.Text = "Clarens";
                tbRegion.Text = "Freestate";
                tbPostalCode.Text = "9707";
            }
            else if (comboBox1.Text == "Jeffreys Bay")
            {
                tbComName.Text = "Minou Estates (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2006/014353/07";
                tbOffice.Text = "Fine & Country Jeffreys Bay";
                tbStreet.Text = "Shop G, 94A, Fountains Mail";
                tbArea.Text = "Jeffreys Bay ";
                tbRegion.Text = "Eastern Cape";
                tbPostalCode.Text = "6330";
            }
            else if (comboBox1.Text == "Betty's Bay")
            {
                tbComName.Text = "Oppie Bosch Real Estate Management Solutions";
                tbRegNo.Text = "Reg No: 2008/053745/23";
                tbOffice.Text = "Fine & Country Betty's Bay";
                tbStreet.Text = "3308 Pearl Drive, Sunny Seas";
                tbArea.Text = "Betty's Bay";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7141";
            }
            else if (comboBox1.Text == "Knysna")
            {
                tbComName.Text = "Tradelink Properties (Pty) Ltd";
                tbRegNo.Text = "Reg No:  2015/312290/07";
                tbOffice.Text = "Fine & Country Knysna";
                tbStreet.Text = "4 Waterfront Drive";
                tbArea.Text = "Knysna";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "6570";
            }
            else if (comboBox1.Text == "George")
            {
                tbComName.Text = "Tradelink Properties (Pty) Ltd";
                tbRegNo.Text = "Reg No:  2015/312290/07";
                tbOffice.Text = "Fine & Country George";
                tbStreet.Text = "Leodor Centre";
                tbArea.Text = "Cnr York and Laing Street";
                tbRegion.Text = "George, Western Cape";
                tbPostalCode.Text = "6529";
            }
            else if (comboBox1.Text == "Helderberg")
            {
                tbComName.Text = "Finman231 (Pty) Ltd";
                tbRegNo.Text = "Reg No:  2009/015755/07";
                tbOffice.Text = "Fine & Country Helderberg";
                tbStreet.Text = "Mayfair, 3 Bright Street";
                tbArea.Text = "Somerset West";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7130";
            }
            else if (comboBox1.Text == "Helderberg (Sales)")
            {
                tbComName.Text = "Finman231 (Pty) Ltd";
                tbRegNo.Text = "Reg No:  2009/015755/07";
                tbOffice.Text = "Fine & Country Helderberg";
                tbStreet.Text = "Mayfair, 3 Bright Street";
                tbArea.Text = "Somerset West";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7130";
            }
            else if (comboBox1.Text == "Helderberg (Rentals)")
            {
                tbComName.Text = "Finman231 (Pty) Ltd";
                tbRegNo.Text = "Reg No:  2009/015755/07";
                tbOffice.Text = "Fine & Country Helderberg";
                tbStreet.Text = "Shop 9, Vergelegen Plein";
                tbArea.Text = "Old Sir Lowry's Pass Road";
                tbRegion.Text = "Somerset West, WC";
                tbPostalCode.Text = "7130";
            }
            else if (comboBox1.Text == "Pinelands")
            {
                tbComName.Text = "Sharon van Rensburg Properties";
                tbRegNo.Text = "Reg No:  2005/1034301";
                tbOffice.Text = "Fine & Country Pinelands";
                tbStreet.Text = "8 Long Place";
                tbArea.Text = "Pinelands";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7405";
            }
            else if (comboBox1.Text == "Langebaan")
            {
                tbComName.Text = "Sonvangar Beleggings (Edms) Bpk";
                tbRegNo.Text = "Reg No: 2015/372826/07";
                tbOffice.Text = "Fine & Country Langebaan";
                tbStreet.Text = "LBN Centre";
                tbArea.Text = "5 Leentjiesklip Road";
                tbRegion.Text = "Langebaan, Western Cape";
                tbPostalCode.Text = "7357";
            }
            else if (comboBox1.Text == "JHB North West")
            {
                tbComName.Text = "West Rand Realty (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2015/397446/07";
                tbOffice.Text = "F&C JHB North West";
                tbStreet.Text = "29 Autumn Road";
                tbArea.Text = "Rivonia, Sandton";
                tbRegion.Text = "Gauteng";
                tbPostalCode.Text = "2191";
            }
            else if (comboBox1.Text == "Noordhoek")
            {
                tbComName.Text = "Before the Wind Investments 209 (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2006/0111108/07";
                tbOffice.Text = "Fine & Country Noordhoek";
                tbStreet.Text = "Shop 8 Old Village";
                tbArea.Text = "Constantia Village Centre";
                tbRegion.Text = "Constantia, Western Cape";
                tbPostalCode.Text = "7806";
            }
            else if (comboBox1.Text == "Western Seaboard")
            {
                tbComName.Text = "Cosmic Gold Trading 548 CC";
                tbRegNo.Text = "Reg No: 2008/213307/23";
                tbOffice.Text = "F&C Werstern Seaboard";
                tbStreet.Text = "8 Redcliffe Road";
                tbArea.Text = "Parklands, Cape Town";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7441";
            }

            else if (comboBox1.Text == "Durbanville")
            {
                tbComName.Text = "Cronus Investments CC";
                tbRegNo.Text = "Reg No: 2011/095310/23";
                tbOffice.Text = "Fine & Country Durbanville";
                tbStreet.Text = "Unit A1, Anansi Park";
                tbArea.Text = "25 Church Street, Durbanville";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7550";
            }

            else if (comboBox1.Text == "False Bay")
            {
                tbComName.Text = "False Bay Properties (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2005/042015/07";
                tbOffice.Text = "Fine & Country False Bay";
                tbStreet.Text = "Shop 4, Fish Hoek Centre";
                tbArea.Text = "90 Main Road, Fish Hoek";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7975";
            }

            else if (comboBox1.Text == "Franchhoek")
            {
                tbComName.Text = "Thinvest CC";
                tbRegNo.Text = "Reg No: 2008/038615/23";
                tbOffice.Text = "Fine & Country Franschhoek";
                tbStreet.Text = "23 Huguenot Street";
                tbArea.Text = "Franschhoek";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7690";
            }

            else if (comboBox1.Text == "Hermanus")
            {
                tbComName.Text = "Suger Creek Trading 300 (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2010/021366/07";
                tbOffice.Text = "Fine & Country Hermanus";
                tbStreet.Text = "Optimum Centre, 10 Main Road";
                tbArea.Text = "Onrus River, Hermanus";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7201";
            }

            else if (comboBox1.Text == "Mossel Bay")
            {
                tbComName.Text = "Fine & Country Mossel Bay and Hartenbos CC";
                tbRegNo.Text = "Reg No: 89/00545/23";
                tbOffice.Text = "Fine & Country Mossel Bay";
                tbStreet.Text = "1 Pinnacle Point Road";
                tbArea.Text = "Pinnacle Point, Mossel Bay";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "6506";
            }

            else if (comboBox1.Text == "Overberg")
            {
                tbComName.Text = "Walker Bay Plots and Homes CC";
                tbRegNo.Text = "Reg No: 1994/014131/23";
                tbOffice.Text = "Fine & Country Overberg";
                tbStreet.Text = "26 Fabriek Street";
                tbArea.Text = "Gansbaai";
                tbRegion.Text = "Western Cape";
                tbPostalCode.Text = "7220";
            }

            else if (comboBox1.Text == "St Francis Bay")
            {
                tbComName.Text = "Hope Estate St Francis Bay (Pty) Ltd";
                tbRegNo.Text = "Reg no: 2016/045114/07";
                tbOffice.Text = "Fine & Country St Francis Bay";
                tbStreet.Text = "Shop 16, Village Square";
                tbArea.Text = "6 St Francis Drive";
                tbRegion.Text = "St Francis Bay, Western Cape";
                tbPostalCode.Text = "6312";
            }

            else if (comboBox1.Text == "Stellenbosch")
            {
                tbComName.Text = "Fine and Country Stellenbosch (Pty) Ltd";
                tbRegNo.Text = "Reg No: 2016/152570/07";
                tbOffice.Text = "Fine & Country Stellenbosch";
                tbStreet.Text = "Block A, Ground Floor";
                tbArea.Text = "De Wagenweg Office Park";
                tbRegion.Text = "Stellentia Road, Western Cape";
                tbPostalCode.Text = "7600";
            }

            else if (comboBox1.Text == "Helderberg Schonenberg Office")
            {
                tbComName.Text = "Finman119cc";
                tbRegNo.Text = "Reg No:  2000/074349/23";
                tbOffice.Text = "Fine & Country Stellenbosch";
                tbStreet.Text = "Voorbrug Avenue, off Main Rd";
                tbArea.Text = "Schonenberg Estate";
                tbRegion.Text = "Somerset West, WC";
                tbPostalCode.Text = "7130";
            }

            else
            {
                tbComName.Text = "Company Name";
                tbRegNo.Text = "Registration number";
                tbOffice.Text = "Fine & Country Office";
                tbStreet.Text = "Street number / name";
                tbArea.Text = "Area  (City/Town/Suburb)";
                tbRegion.Text = "Region";
                tbPostalCode.Text = "Street Postal Code";
            }
        }
    }
}
