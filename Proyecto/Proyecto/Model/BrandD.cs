using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Data;
using NpgsqlTypes;

namespace Model
{
    public class BrandD
    {
        private PostgressDataAccess connection;

        private bool error;
        public bool Error
        {
            get { return error; }
        }

        private string errorMsg;
        public string ErrorMsg
        {
            get { return errorMsg; }
        }

        public BrandD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<BrandE> getBrands()
        {
            this.cleanError();
            List<BrandE> brands = new List<BrandE>();
            DataSet dsetBrands;
            try
            {
                string sql = "SELECT b.brandcod AS codigo, b.branddescription AS descripcion " +
                    "FROM brand b;";

                dsetBrands = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dsetBrands.Tables[0].Rows)
                {
                    BrandE oBrandE = new BrandE(int.Parse(tuple["codigo"].ToString()), tuple["descripcion"].ToString());
                    brands.Add(oBrandE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return brands;
        }
        public Boolean insertBrand(BrandE oBrandE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO brand(brandcod, branddescription)" +
                    " VALUES (@brandcod, @branddescription);";

                oParameters.addParameter("@brandcod", NpgsqlDbType.Numeric, oBrandE.Code);
                oParameters.addParameter("@branddescription", NpgsqlDbType.Varchar, oBrandE.Description);

                this.connection.executeSQL(sql, oParameters.getParameter());

                if (this.connection.IsError)
                {
                    error = true;
                    this.errorMsg = this.connection.descriptionError;
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
                return false;
            }

        }
        /*
        public Boolean updateClient(ClientE oClientN)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE client SET clientname = @clientname, lastname1 = @lastname1, lastname2 = @lastname2," +
                    " officephone = @officephone, housephone = @housephone, celphone = @celphone, fax = @fax, address = @address" +
                    " WHERE clientid = @clientid;";

                oParameters.addParameter("@clientid", NpgsqlDbType.Varchar, oClientN.Cedula);
                oParameters.addParameter("@clientname", NpgsqlDbType.Varchar, oClientN.Name);
                oParameters.addParameter("@lastname1", NpgsqlDbType.Varchar, oClientN.LastName1);
                oParameters.addParameter("@lastname2", NpgsqlDbType.Varchar, oClientN.LastName2);
                oParameters.addParameter("@officephone", NpgsqlDbType.Numeric, oClientN.OfficePhone);
                oParameters.addParameter("@housephone", NpgsqlDbType.Numeric, oClientN.HousePhone);
                oParameters.addParameter("@celphone", NpgsqlDbType.Numeric, oClientN.Celphone);
                oParameters.addParameter("@fax", NpgsqlDbType.Numeric, oClientN.Fax);
                oParameters.addParameter("@address", NpgsqlDbType.Varchar, oClientN.Address);

                this.connection.executeSQL(sql, oParameters.getParameter());

                if (this.connection.IsError)
                {
                    error = true;
                    this.errorMsg = this.connection.descriptionError;
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
                return false;
            }
        }
        public Boolean deleteClient(string id)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM client WHERE clientid = @id;";

                oParameters.addParameter("@id", NpgsqlDbType.Varchar, id);
                this.connection.executeSQL(sql, oParameters.getParameter());

                if (this.connection.IsError)
                {
                    error = true;
                    this.errorMsg = this.connection.descriptionError;
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
                return false;
            }
        }*/
    }
}
