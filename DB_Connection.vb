﻿Imports MySql.Data.MySqlClient

Module DB_Connection
    Public Function strstrconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost; user id=root; Password=; Database=id_processing_db_test; sslMode=none; Convert Zero DateTime=true;")
    End Function

    Public strcon As MySqlConnection = strstrconnection()

End Module
