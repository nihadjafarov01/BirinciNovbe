﻿namespace Core.Models;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}