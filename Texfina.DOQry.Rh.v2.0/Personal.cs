﻿using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Rh;

namespace Texfina.DOQry.Rh
{
   /// <summary>
   /// Data Object para Consultas a la Tabla: Personal (RH_Personal)
   /// </summary>
   /// <remarks></remarks>
   public class Personal : DataObjectBase, IDOQuery
   {

      #region IDOQuery Members
  
      public DataTable GetByCriteria(IEntityBase value)
      {

         EPersonalBandeja objE = (EPersonalBandeja)value;

         try
         {

            ArrayList arrPrm = new ArrayList();
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pnuDocIden", SqlDbType.VarChar, 20, objE.NuDocIden));
            arrPrm.Add(DataHelper.CreateParameter("@pdsApellNom", SqlDbType.VarChar, 150, objE.DsApellNom));

            DataTable dt = this.ExecuteDatatable("RH_Personal_qry01", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public IEntityBase GetByKey(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_Personal_qry02", arrPrm);

            objE = null;

            foreach (DataRow dr in dt.Rows)
               objE = DataHelper.CopyDataRowToEntity<EPersonal>(dr, typeof(EPersonal));

            return objE;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetByParentKey(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_Personal_qry03", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetList(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_Personal_qry04", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public bool Exists(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);
            int intIdx = arrPrm.Add(DataHelper.CreateParameter("@pexists", SqlDbType.Char, 1, ParameterDirection.InputOutput, "0"));

            SqlParameter[] objPrm = (SqlParameter[])arrPrm.ToArray(typeof(SqlParameter));

            DataTable dt = this.ExecuteDatatable("RH_Personal_qry05", arrPrm);

            return objPrm[intIdx].Value.ToString() == "1" ? true : false;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      private ArrayList BuildParamInterface(EPersonal value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));

         return arrPrm;

      }

      #endregion

      public DataTable GetPlanillaXPersonal(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         try
         {
             ArrayList arrPrm = BuildParamInterface(objE);
        

            DataTable dt = this.ExecuteDatatable("RH_Personal_qry10", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetCliProvXPersonal(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            DataTable dt = this.ExecuteDatatable("RH_Personal_qry11", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetPersonalxPlanilla(IEntityBase value)
      {

          EPersonalPlanilla objE = (EPersonalPlanilla)value;

          try
          {

              ArrayList arrPrm = new ArrayList();
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
              arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
              arrPrm.Add(DataHelper.CreateParameter("@pnuDocIden", SqlDbType.VarChar, 20, objE.NuDocIden));
              arrPrm.Add(DataHelper.CreateParameter("@pdsApellNom", SqlDbType.VarChar, 150, objE.DsApellNom));

              DataTable dt = this.ExecuteDatatable("RH_Personal_qry13", arrPrm);

              return dt;
          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }

      public DataTable GetVacaPersonalGrupal(IEntityBase value)
      {

         EPerVacaProg objE = (EPerVacaProg)value;

         try
         {

            ArrayList arrPrm = new ArrayList();
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.VarChar, 8000, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pidPeriVac", SqlDbType.Char, 4, objE.IdPeriVac));

            DataTable dt = this.ExecuteDatatable("RH_Personal_qry14", arrPrm);

            return dt;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }
      }

      public DataTable GetByCriteriaVacacion(IEntityBase value)
      {

          EPersonalBandeja objE = (EPersonalBandeja)value;

          try
          {

              ArrayList arrPrm = new ArrayList();
              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
              arrPrm.Add(DataHelper.CreateParameter("@pnuDocIden", SqlDbType.VarChar, 20, objE.NuDocIden));
              arrPrm.Add(DataHelper.CreateParameter("@pdsApellNom", SqlDbType.VarChar, 150, objE.DsApellNom));
              arrPrm.Add(DataHelper.CreateParameter("@pidPlanilla", SqlDbType.Char, 3, objE.IdPlanilla));
              arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, objE.IdEstable));
              arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, objE.IdUNegocio));
              arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, objE.IdCCosto));
              arrPrm.Add(DataHelper.CreateParameter("@pidMes", SqlDbType.Char, 3, objE.IdMes));
              arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));

              DataTable dt = this.ExecuteDatatable("RH_Personal_qry15", arrPrm);

              return dt;

          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }
      }
   }
}
