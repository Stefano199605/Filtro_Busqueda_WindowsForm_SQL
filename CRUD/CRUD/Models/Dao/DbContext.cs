﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models.Dao
{
   public  class DbContext
    {
        protected SqlConnection Conexion =
           new SqlConnection(
               "Server=DESKTOP-3LUEQ59;DataBase=Practica_Patrones;UID=sa;password=p0deroso12"
               );
    }
}
