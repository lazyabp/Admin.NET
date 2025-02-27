﻿using Microsoft.EntityFrameworkCore;

namespace Admin.NET.Core
{
    /// <summary>
    /// 自定义租户基类实体
    /// </summary>
    public abstract class DBEntityTenant : DEntityBase
    {
        /// <summary>
        /// 租户id
        /// </summary>
        [Comment("租户id")]
        public virtual long? TenantId { get; set; }
    }
}