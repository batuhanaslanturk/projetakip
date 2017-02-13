using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projetakibi
{
    class Sınıflar
    {
         int Sinifid;
         public   String Sinifadi;
         public String Derslik;
         public String Alani;
         public String Sinifogretmeni;
         public String Mdyardimcisi;
         Vtislemleri vt;

         public bool Kaydet()
        {
            int sonuc;
            string Sqlcumlesi = "insert into Siniflar(Sinifadi,Derslik,Alani,Sinifogretmeni,Mdyardimcisi) values('" + Sinifadi + "','" + Derslik + "','" + Alani + "','" + Sinifogretmeni + "','" + Mdyardimcisi + "')";
            vt = new Vtislemleri();
            sonuc=vt.Kayitgir(Sqlcumlesi);
            return (sonuc>0);
        }
         public bool Guncelle()
        {
            int sonuc;
            vt=new Vtislemleri();
            System.Data.OleDb.OleDbCommand komut=vt.Komutgetir();
            komut.CommandText = "update Siniflar set Sinifadi=@sa, Derslik=@d,Alani=@alani,Sinifogretmeni=@so,Mdyardimcisi=@md";
            komut.Parameters.AddWithValue("sa", Sinifadi);
            komut.Parameters.AddWithValue("d", Derslik);
            komut.Parameters.AddWithValue("alani", Alani);
            komut.Parameters.AddWithValue("so",Sinifogretmeni);
            komut.Parameters.AddWithValue("md", Mdyardimcisi);
            sonuc = vt.Komutcalistir(komut);
            return (sonuc > 0);

        }
         public override string ToString()
         {
             return Sinifadi;
         }
    }
}
