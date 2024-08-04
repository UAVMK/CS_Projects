﻿using GrainElevatorCS_ef.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static ElevatorControlSystem.MainWindow;

public class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public string City { get; set; } = null!;

    public string? Country { get; set; }
    public Roles Role { get; set; }

    public virtual ICollection<CompletionReport> CompletionReports { get; set; } = new List<CompletionReport>();

    public virtual ICollection<InputInvoice> InputInvoices { get; set; } = new List<InputInvoice>();

    public virtual ICollection<LaboratoryCard> LaboratoryCards { get; set; } = new List<LaboratoryCard>();

    public virtual ICollection<OutputInvoice> OutputInvoices { get; set; } = new List<OutputInvoice>();

    public virtual ICollection<PriceList> PriceLists { get; set; } = new List<PriceList>();

    public virtual ICollection<Register> Registers { get; set; } = new List<Register>();


    public User() { }

    public User(string firstName, string lastName, DateTime birthDate, string email, string phone, string password, string gender, string city, string country, Roles roles)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Email = email;
        Phone = phone;
        City = city;
        Password = password;
        Gender = gender;
        Country = country;
        Role = roles;
    }
}

