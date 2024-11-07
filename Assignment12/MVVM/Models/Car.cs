using SQLite;
using System;


namespace Assignment12.MVVM.Models;

public class Car
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [Column("car_id")]
    public string CarId { get; set; }

    [Column("model")]
    public string Model { get; set; }

    [Column("color")]
    public string Color { get; set; }
}
