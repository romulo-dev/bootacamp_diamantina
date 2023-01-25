using Dapper;
using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
// using Tarefas.DTO;

namespace Tarefas.DAO{
    public class TarefaDAO{
        public string DataSourceFile => Environment.CurrentDirectory + "Tarefas.sqlite";
        public SQLiteConnection Connection => new SQLiteConnection("DataSource=" + DataSourceFile);
    
    public TarefaDAO(){
        if(!File.Exists(DataSourceFile)){
            createDatabase();
        }
    }

    public void createDatabase(){
        using (var con = Connection){
         con.Open();
        con.Execute(
        @"CREATE TABLE Tarefa
        {
            ID integer primary key autoincremment,
            Titulo varchar(100) not null,
            Descricao varchar(100) not null
        }");   
        }
        
        

    }
    
    }
}