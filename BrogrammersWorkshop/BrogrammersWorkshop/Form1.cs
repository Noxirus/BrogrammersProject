using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrogrammersWorkshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private List<Packages> pack = PackagesDB.GetPackages();
        private List<PackagesProductInfo> packProdSupp = Packages_Products_SuppliersDB.GetPackProductsSuppliers();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboPckID.DataSource = pack;
            comboPckID.DisplayMember = "PackageId";
        }

        private void comboPckID_SelectedIndexChanged(object sender, EventArgs e)
        { string packIDSelected = comboPckID.Text;
            foreach(var packs in pack)
            {
                if (Convert.ToString(packs.PackageId) == packIDSelected)
                {
                    txtPckName.Text = Convert.ToString(packs.PkgName);
                    txtBasePrice.Text = Convert.ToString(packs.PkgBasePrice);
                    txtAgencyCommision.Text = Convert.ToString(packs.PkgAgencyComission);
                    txtPckDesc.Text = packs.PkgDesc;


                    if (packs.PkgStartDate.HasValue)
                    {
                        txtPckStart.Text = packs.PkgStartDate.Value.ToShortDateString();
                    }

                    else
                    {
                        txtPckStart.Text = " ";
                    }


                    if (packs.PkgEndDate.HasValue)
                    {
                        txtPckEnd.Text = packs.PkgEndDate.Value.ToShortDateString();
                    }

                    else
                    {
                        txtPckEnd.Text = " ";
                    }
                }
                   




            }

            List<object> pkdprdsupp = new List<Object>();

                foreach(var prdsupp in packProdSupp)
                {
                if (Convert.ToString(prdsupp.PackageId) == packIDSelected)
                    {
                        pkdprdsupp.Add(prdsupp);
                    }

                }

            pckProductSupplier.DataSource = pkdprdsupp;

        }
              
    }
}
