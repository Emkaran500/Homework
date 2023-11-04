using System.Data.SqlClient;
using EB_DZ_50.Entities;

namespace EB_DZ_50.Repositories;
public class ToDoTaskRepository
{
    private SqlConnection sqlConnection;
    private const string connectionStringLP = "Server=localhost;Database=ToDoDB;User Id=admin;Password=admin;";
    private const string connectionStringWP = "Server=localhost;Database=ToDoDB;Trusted_Connection=True;";

    public ToDoTaskRepository(bool usePassword)
    {
        if (usePassword)
        {
            this.sqlConnection = new SqlConnection(connectionString: connectionStringLP);
        }
        else
        {
            this.sqlConnection = new SqlConnection(connectionString: connectionStringWP);
        }
    }

    public IEnumerable<ToDoTask> GetAll()
    {
        List<ToDoTask> tasks = new List<ToDoTask>();

        SqlCommand command = new SqlCommand();

        command.Connection = this.sqlConnection;
        command.CommandText = $@"SELECT * FROM Tasks";
        
        SqlDataReader reader = command.ExecuteReader();

        while(reader.Read())
        {
            ToDoTask task = new ToDoTask(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
            tasks.Add(task);
        }

        return tasks;
    }

    public bool Add(ToDoTask task)
    {
        SqlCommand command = new SqlCommand();
        command.Connection = this.sqlConnection;
        command.CommandText = $@"INSERT INTO Tasks([Name], [PriorityID], [StatusID])
                                 VALUES ({task.Name ?? "Unknown"}, {task.PriorityID}, {task.StatusID})";
        
        return command.ExecuteNonQuery() > 0;
    }

    public bool Edit(int id, string columnToEdit, string change)
    {
        SqlCommand command = new SqlCommand();
        command.Connection = this.sqlConnection;
        command.CommandText = $@"UPDATE Tasks t
                                 SET {columnToEdit} = {change}
                                 WHERE t.[ID] = {id}";

        return command.ExecuteNonQuery() > 0;
    }

    public bool Delete(int id)
    {
        SqlCommand command = new SqlCommand();
        command.Connection = this.sqlConnection;
        command.CommandText = $@"DELETE FROM Tasks t
                                 WHERE t.[ID] = {id}";

        return command.ExecuteNonQuery() > 0;
    }

    public int GetMaxCharInName()
    {
        SqlCommand command = new SqlCommand();
        command.Connection = this.sqlConnection;
        command.CommandText = $@"SELECT max(len([Name]))
                                 FROM Tasks";
        
        return (int)command.ExecuteScalar();
    }
}