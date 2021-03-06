﻿using System;
using System.Collections.Generic;

namespace LJD.App.Model.DbModels
{
    public partial class SysRole
    {
        public SysRole()
        {
            R_RolePermission = new HashSet<R_RolePermission>();
            R_sysUserInfo_sysRole = new HashSet<R_sysUserInfo_sysRole>();
        }

        public string ObjectID { get; set; }
        public string RName { get; set; }
        public string Remark { get; set; }
        public int? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? Sort { get; set; }

        public virtual ICollection<R_RolePermission> R_RolePermission { get; set; }
        public virtual ICollection<R_sysUserInfo_sysRole> R_sysUserInfo_sysRole { get; set; }
    }
}
