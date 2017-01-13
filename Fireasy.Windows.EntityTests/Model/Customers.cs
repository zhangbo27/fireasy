// ------------------------------
// ��ģ����CodeBuilder��������,���������� Fireasy.Data.Entity 1.5 ���ݿ��
// ��Ȩ���� (C) Fireasy 2011

// ��Ŀ����: ʵ���ܲ�����Ŀ
// ģ������: �ͻ��� ʵ����
// �����д: Huangxd
// �ļ�·��: C:\Users\Ruibron\Desktop\Model\Customers.cs
// ����ʱ��: 2013/8/14 9:59:25
// ------------------------------

using System;
using Fireasy.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Fireasy.Data.Entity.Test.Model
{
    /// <summary>
    ///  ʵ���ࡣ
    /// </summary>
    [Serializable]
    [EntityMapping("Customers", Description = "")]
    [MetadataType(typeof(CustomersMetadata))]
    public partial class Customers : LighEntityObject<Customers>
    {
        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "CustomerID", Description = "", IsPrimaryKey = true, Length = 5, IsNullable = false)]
        public virtual string CustomerID { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "CompanyName", Description = "", Length = 40, IsNullable = false)]
        public virtual string CompanyName { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "ContactName", Description = "", Length = 30, IsNullable = true)]
        public virtual string ContactName { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "ContactTitle", Description = "", Length = 30, IsNullable = true)]
        public virtual string ContactTitle { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "Address", Description = "", Length = 60, IsNullable = true)]
        public virtual string Address { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "City", Description = "", Length = 15, IsNullable = true)]
        public virtual string City { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "Region", Description = "", Length = 15, IsNullable = true)]
        public virtual string Region { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "PostalCode", Description = "", Length = 10, IsNullable = true)]
        public virtual string PostalCode { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "Country", Description = "", Length = 15, IsNullable = true)]
        public virtual string Country { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "Phone", Description = "", Length = 24, IsNullable = true)]
        public virtual string Phone { get; set; }

        /// <summary>
        /// ��ȡ�����á�
        /// </summary>

        [PropertyMapping(ColumnName = "Fax", Description = "", Length = 24, IsNullable = true)]
        public virtual string Fax { get; set; }

        /// <summary>
        /// ��ȡ������ <see cref="orders"/> ����ʵ�弯��
        /// </summary>
        public virtual EntitySet<Orders> Orderses { get; set; }

    }

    public class CustomersMetadata
    {
        /// <summary>
        /// ���� CustomerID ����֤���ԡ�
        /// </summary>
        [Required]
        [StringLength(5)]
        public object CustomerID { get; set; }

        /// <summary>
        /// ���� CompanyName ����֤���ԡ�
        /// </summary>
        [Required]
        [StringLength(40)]
        public object CompanyName { get; set; }

        /// <summary>
        /// ���� ContactName ����֤���ԡ�
        /// </summary>
        [StringLength(30)]
        public object ContactName { get; set; }

        /// <summary>
        /// ���� ContactTitle ����֤���ԡ�
        /// </summary>
        [StringLength(30)]
        public object ContactTitle { get; set; }

        /// <summary>
        /// ���� Address ����֤���ԡ�
        /// </summary>
        [StringLength(60)]
        public object Address { get; set; }

        /// <summary>
        /// ���� City ����֤���ԡ�
        /// </summary>
        [StringLength(15)]
        public object City { get; set; }

        /// <summary>
        /// ���� Region ����֤���ԡ�
        /// </summary>
        [StringLength(15)]
        public object Region { get; set; }

        /// <summary>
        /// ���� PostalCode ����֤���ԡ�
        /// </summary>
        [StringLength(10)]
        public object PostalCode { get; set; }

        /// <summary>
        /// ���� Country ����֤���ԡ�
        /// </summary>
        [StringLength(15)]
        public object Country { get; set; }

        /// <summary>
        /// ���� Phone ����֤���ԡ�
        /// </summary>
        [StringLength(24)]
        public object Phone { get; set; }

        /// <summary>
        /// ���� Fax ����֤���ԡ�
        /// </summary>
        [StringLength(24)]
        public object Fax { get; set; }

    }
}