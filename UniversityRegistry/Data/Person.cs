﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UniversityRegistry.Data
{
    /// <summary>
    /// A class representing a person associated with the university
    /// </summary>
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The next ID to assign to a newly-created person
        /// </summary>
        public static uint NextID = 80000000;

        private uint id;
        /// <summary>
        /// The uinque identifier of this person
        /// </summary>
        public uint ID
        {
            get { return id; }
            private set
            {
                if (id == value) return;
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ID"));
            }
        }

        private string firstName;
        /// <summary>
        /// The person's first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName == value) return;
                firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
            }
        }

        private string lastName;
        /// <summary>
        /// The person's last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName == value) return;
                lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
            }
        }

        private DateTime dateOfBirth;
        /// <summary>
        /// The person's date of birth
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (dateOfBirth == value) return;
                dateOfBirth = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfBirth"));
            } 
        }

        private bool active;
        /// <summary>
        /// If this person is active in the university (currently a part of the university)
        /// </summary>
        public bool Active 
        { 
            get { return active; }
            set
            {
                if (active == value) return;
                active = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Active"));
            } 
        }

        
        private Role role;
        /// <summary>
        /// The person's role
        /// </summary>
        public Role Role
        {
            get => role;
            set
            {
                if (role == value) return;
                role = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Role"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Role"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsUndergraduateStudent"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsGraduateStudent"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsFaculty"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsStaff"));
            }
        }
        /// <summary>
        /// Creates a new user, assigning them an ID
        /// </summary>
        public Person()
        {
            ID = NextID++;
        }

        /// <summary>
        /// Returns a string identifying the person
        /// </summary>
        /// <returns>A string consitsting of last name, first name, and ID</returns>
        public override string ToString()
        {
            return $"{LastName}, {FirstName}, [{ID}]";
        }
    }
}
