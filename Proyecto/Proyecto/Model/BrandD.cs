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
        
        public Boolean updateBrand(BrandE oBrandE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE brand SET branddescription = @branddescription" +
                    " WHERE brandcod = @brandcod;";

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
        public Boolean deleteBrand(string code)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM brand WHERE brandcod = @brandcod;";

                oParameters.addParameter("@brandcod", NpgsqlDbType.Numeric, code);
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
    }
}
