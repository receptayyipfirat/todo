﻿using Cil.Todo.Data.Model.Enum;
using System;

namespace Cil.Todo.Data.Model.Domain
{
    public partial class User : BaseEntity, IAuditEntity
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        #region IAuditEntity
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }
        #endregion
    }
}
