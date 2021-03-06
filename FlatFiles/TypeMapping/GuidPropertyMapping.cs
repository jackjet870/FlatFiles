﻿using System;
using System.Reflection;

namespace FlatFiles.TypeMapping
{
    /// <summary>
    /// Represents the mapping from a type property to a Guid column.
    /// </summary>
    public interface IGuidPropertyMapping
    {
        /// <summary>
        /// Sets the name of the column in the input or output file.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <returns>The property mapping for further configuration.</returns>
        IGuidPropertyMapping ColumnName(string name);

        /// <summary>
        /// Sets the format to use when reading input.
        /// </summary>
        /// <param name="format">The format to use.</param>
        /// <returns>The property mapping for further configuration.</returns>
        IGuidPropertyMapping InputFormat(string format);

        /// <summary>
        /// Sets the format to use when writing output.
        /// </summary>
        /// <param name="format">The format to use.</param>
        /// <returns>The property mapping for further configuration.</returns>
        IGuidPropertyMapping OutputFormat(string format);
    }

    internal sealed class GuidPropertyMapping : IGuidPropertyMapping, IPropertyMapping
    {
        private readonly GuidColumn column;
        private readonly PropertyInfo property;

        public GuidPropertyMapping(GuidColumn column, PropertyInfo property)
        {
            this.column = column;
            this.property = property;
        }

        public IGuidPropertyMapping ColumnName(string name)
        {
            this.column.ColumnName = name;
            return this;
        }

        public IGuidPropertyMapping InputFormat(string format)
        {
            this.column.InputFormat = format;
            return this;
        }

        public IGuidPropertyMapping OutputFormat(string format)
        {
            this.column.OutputFormat = format;
            return this;
        }

        public PropertyInfo Property
        {
            get { return property; }
        }

        public ColumnDefinition ColumnDefinition
        {
            get { return column; }
        }
    }
}
