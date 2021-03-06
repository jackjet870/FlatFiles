﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using FlatFiles.Properties;

namespace FlatFiles.TypeMapping
{
    /// <summary>
    /// Provides methods for creating type mappers.
    /// </summary>
    public static class SeparatedValueTypeMapper
    {
        /// <summary>
        /// Creates an object that can be used to configure the mapping to and from an entity and a flat file record.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity whose properties will be mapped.</typeparam>
        /// <returns>The configuration object.</returns>
        public static ISeparatedValueTypeMapper<TEntity> Define<TEntity>()
        {
            return new SeparatedValueTypeMapper<TEntity>(() => Activator.CreateInstance<TEntity>());
        }

        /// <summary>
        /// Creates an object that can be used to configure the mapping to and from an entity and a flat file record.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity whose properties will be mapped.</typeparam>
        /// <param name="factory">A method to call when creating a new entity.</param>
        /// <returns>The configuration object.</returns>
        public static ISeparatedValueTypeMapper<TEntity> Define<TEntity>(Func<TEntity> factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException("factory");
            }
            return new SeparatedValueTypeMapper<TEntity>(factory);
        }
    }

    /// <summary>
    /// Supports configuration for mapping between entity properties and flat file columns.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity being mapped.</typeparam>
    public interface ISeparatedValueTypeMapper<TEntity>
    {
        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IBooleanPropertyMapping Property(Expression<Func<TEntity, bool>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IBooleanPropertyMapping Property(Expression<Func<TEntity, bool?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IByteArrayPropertyMapping Property(Expression<Func<TEntity, byte[]>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IBytePropertyMapping Property(Expression<Func<TEntity, byte>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IBytePropertyMapping Property(Expression<Func<TEntity, byte?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        ICharArrayPropertyMapping Property(Expression<Func<TEntity, char[]>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        ICharPropertyMapping Property(Expression<Func<TEntity, char>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        ICharPropertyMapping Property(Expression<Func<TEntity, char?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IDateTimePropertyMapping Property(Expression<Func<TEntity, DateTime>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IDateTimePropertyMapping Property(Expression<Func<TEntity, DateTime?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IDecimalPropertyMapping Property(Expression<Func<TEntity, decimal>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IDecimalPropertyMapping Property(Expression<Func<TEntity, decimal?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IDoublePropertyMapping Property(Expression<Func<TEntity, double>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IDoublePropertyMapping Property(Expression<Func<TEntity, double?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IGuidPropertyMapping Property(Expression<Func<TEntity, Guid>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IGuidPropertyMapping Property(Expression<Func<TEntity, Guid?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IInt16PropertyMapping Property(Expression<Func<TEntity, short>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IInt16PropertyMapping Property(Expression<Func<TEntity, short?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IInt32PropertyMapping Property(Expression<Func<TEntity, int>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IInt32PropertyMapping Property(Expression<Func<TEntity, int?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IInt64PropertyMapping Property(Expression<Func<TEntity, long>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IInt64PropertyMapping Property(Expression<Func<TEntity, long?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        ISinglePropertyMapping Property(Expression<Func<TEntity, float>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        ISinglePropertyMapping Property(Expression<Func<TEntity, float?>> property);

        /// <summary>
        /// Associates the property with the type mapper and returns an object for configuration.
        /// </summary>
        /// <param name="property">An expression that returns the property to map.</param>
        /// <returns>An object to configure the property mapping.</returns>
        IStringPropertyMapping Property(Expression<Func<TEntity, string>> property);

        /// <summary>
        /// Gets the schema defined by the current configuration.
        /// </summary>
        /// <returns>The schema.</returns>
        SeparatedValueSchema GetSchema();

        /// <summary>
        /// Reads the entities from the file at the given path.
        /// </summary>
        /// <param name="fileName">The path of the file to read.</param>
        /// <returns>The entities that are extracted from the file.</returns>
        IEnumerable<TEntity> Read(string fileName);

        /// <summary>
        /// Reads the entities from the file at the given path.
        /// </summary>
        /// <param name="fileName">The path of the file to read.</param>
        /// <param name="options">The options to use.</param>
        /// <returns>The entities that are extracted from the file.</returns>
        IEnumerable<TEntity> Read(string fileName, SeparatedValueOptions options);

        /// <summary>
        /// Reads the entities from the given stream.
        /// </summary>
        /// <param name="stream">The input stream to read.</param>
        /// <returns>The entities that are extracted from the file.</returns>
        IEnumerable<TEntity> Read(Stream stream);

        /// <summary>
        /// Reads the entities from the given stream.
        /// </summary>
        /// <param name="stream">The input stream to read.</param>
        /// <param name="options">The options to use.</param>
        /// <returns>The entities that are extracted from the file.</returns>
        IEnumerable<TEntity> Read(Stream stream, SeparatedValueOptions options);

        /// <summary>
        /// Writes the given entities to the file at the given path.
        /// </summary>
        /// <param name="fileName">The path of the file to write to.</param>
        /// <param name="entities">The entities to write to the file.</param>
        void Write(string fileName, IEnumerable<TEntity> entities);

        /// <summary>
        /// Writes the given entities to the file at the given path.
        /// </summary>
        /// <param name="fileName">The path of the file to write to.</param>
        /// <param name="options">The options to use.</param>
        /// <param name="entities">The entities to write to the file.</param>
        void Write(string fileName, SeparatedValueOptions options, IEnumerable<TEntity> entities);

        /// <summary>
        /// Writes the given entities to the given stream.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="entities">The entities to write to the stream.</param>
        void Write(Stream stream, IEnumerable<TEntity> entities);

        /// <summary>
        /// Writes the given entities to the given stream.
        /// </summary>
        /// <param name="stream">The stream to write to.</param>
        /// <param name="options">The options to use.</param>
        /// <param name="entities">The entities to write to the stream.</param>
        void Write(Stream stream, SeparatedValueOptions options, IEnumerable<TEntity> entities);
    }

    internal sealed class SeparatedValueTypeMapper<TEntity> : ISeparatedValueTypeMapper<TEntity>
    {
        private readonly Func<TEntity> factory;
        private readonly Dictionary<string, IPropertyMapping> mappings;
        private readonly Dictionary<string, int> indexes;
        private int columnCount;

        internal SeparatedValueTypeMapper(Func<TEntity> factory)
        {
            this.factory = factory;
            this.mappings = new Dictionary<string, IPropertyMapping>();
            this.indexes = new Dictionary<string, int>();
        }

        public IBooleanPropertyMapping Property(Expression<Func<TEntity, bool>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getBooleanMapping(propertyInfo);
        }

        public IBooleanPropertyMapping Property(Expression<Func<TEntity, bool?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getBooleanMapping(propertyInfo);
        }

        private IBooleanPropertyMapping getBooleanMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                BooleanColumn column = new BooleanColumn(propertyInfo.Name);
                mapping = new BooleanPropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IBooleanPropertyMapping)mapping;
        }

        public IByteArrayPropertyMapping Property(Expression<Func<TEntity, byte[]>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getByteArrayMapping(propertyInfo);
        }

        private IByteArrayPropertyMapping getByteArrayMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                ByteArrayColumn column = new ByteArrayColumn(propertyInfo.Name);
                mapping = new ByteArrayPropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IByteArrayPropertyMapping)mapping;
        }

        public IBytePropertyMapping Property(Expression<Func<TEntity, byte>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getByteMapping(propertyInfo);
        }

        public IBytePropertyMapping Property(Expression<Func<TEntity, byte?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getByteMapping(propertyInfo);
        }

        private IBytePropertyMapping getByteMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                ByteColumn column = new ByteColumn(propertyInfo.Name);
                mapping = new BytePropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IBytePropertyMapping)mapping;
        }

        public ICharArrayPropertyMapping Property(Expression<Func<TEntity, char[]>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getCharArrayMapping(propertyInfo);
        }

        private ICharArrayPropertyMapping getCharArrayMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                CharArrayColumn column = new CharArrayColumn(propertyInfo.Name);
                mapping = new CharArrayPropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (ICharArrayPropertyMapping)mapping;
        }

        public ICharPropertyMapping Property(Expression<Func<TEntity, char>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getCharMapping(propertyInfo);
        }

        public ICharPropertyMapping Property(Expression<Func<TEntity, char?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getCharMapping(propertyInfo);
        }

        private ICharPropertyMapping getCharMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                CharColumn column = new CharColumn(propertyInfo.Name);
                mapping = new CharPropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (ICharPropertyMapping)mapping;
        }

        public IDateTimePropertyMapping Property(Expression<Func<TEntity, DateTime>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getDateTimeMapping(propertyInfo);
        }

        public IDateTimePropertyMapping Property(Expression<Func<TEntity, DateTime?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getDateTimeMapping(propertyInfo);
        }

        private IDateTimePropertyMapping getDateTimeMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                DateTimeColumn column = new DateTimeColumn(propertyInfo.Name);
                mapping = new DateTimePropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IDateTimePropertyMapping)mapping;
        }

        public IDecimalPropertyMapping Property(Expression<Func<TEntity, decimal>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getDecimalMapping(propertyInfo);
        }

        public IDecimalPropertyMapping Property(Expression<Func<TEntity, decimal?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getDecimalMapping(propertyInfo);
        }

        private IDecimalPropertyMapping getDecimalMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                DecimalColumn column = new DecimalColumn(propertyInfo.Name);
                mapping = new DecimalPropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IDecimalPropertyMapping)mapping;
        }

        public IDoublePropertyMapping Property(Expression<Func<TEntity, double>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getDoubleMapping(propertyInfo);
        }

        public IDoublePropertyMapping Property(Expression<Func<TEntity, double?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getDoubleMapping(propertyInfo);
        }

        private IDoublePropertyMapping getDoubleMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                DoubleColumn column = new DoubleColumn(propertyInfo.Name);
                mapping = new DoublePropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IDoublePropertyMapping)mapping;
        }

        public IGuidPropertyMapping Property(Expression<Func<TEntity, Guid>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getGuidMapping(propertyInfo);
        }

        public IGuidPropertyMapping Property(Expression<Func<TEntity, Guid?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getGuidMapping(propertyInfo);
        }

        private IGuidPropertyMapping getGuidMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                GuidColumn column = new GuidColumn(propertyInfo.Name);
                mapping = new GuidPropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IGuidPropertyMapping)mapping;
        }

        public IInt16PropertyMapping Property(Expression<Func<TEntity, short>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getInt16Mapping(propertyInfo);
        }

        public IInt16PropertyMapping Property(Expression<Func<TEntity, short?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getInt16Mapping(propertyInfo);
        }

        private IInt16PropertyMapping getInt16Mapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                Int16Column column = new Int16Column(propertyInfo.Name);
                mapping = new Int16PropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IInt16PropertyMapping)mapping;
        }

        public IInt32PropertyMapping Property(Expression<Func<TEntity, int>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getInt32Mapping(propertyInfo);
        }

        public IInt32PropertyMapping Property(Expression<Func<TEntity, int?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getInt32Mapping(propertyInfo);
        }

        private IInt32PropertyMapping getInt32Mapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                Int32Column column = new Int32Column(propertyInfo.Name);
                mapping = new Int32PropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IInt32PropertyMapping)mapping;
        }

        public IInt64PropertyMapping Property(Expression<Func<TEntity, long>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getInt64Mapping(propertyInfo);
        }

        public IInt64PropertyMapping Property(Expression<Func<TEntity, long?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getInt64Mapping(propertyInfo);
        }

        private IInt64PropertyMapping getInt64Mapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                Int64Column column = new Int64Column(propertyInfo.Name);
                mapping = new Int64PropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IInt64PropertyMapping)mapping;
        }

        public ISinglePropertyMapping Property(Expression<Func<TEntity, float>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getSingleMapping(propertyInfo);
        }

        public ISinglePropertyMapping Property(Expression<Func<TEntity, float?>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getSingleMapping(propertyInfo);
        }

        private ISinglePropertyMapping getSingleMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                SingleColumn column = new SingleColumn(propertyInfo.Name);
                mapping = new SinglePropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (ISinglePropertyMapping)mapping;
        }

        public IStringPropertyMapping Property(Expression<Func<TEntity, string>> property)
        {
            PropertyInfo propertyInfo = getProperty(property);
            return getStringMapping(propertyInfo);
        }

        private IStringPropertyMapping getStringMapping(PropertyInfo propertyInfo)
        {
            IPropertyMapping mapping;
            if (!mappings.TryGetValue(propertyInfo.Name, out mapping))
            {
                StringColumn column = new StringColumn(propertyInfo.Name);
                mapping = new StringPropertyMapping(column, propertyInfo);
                mappings.Add(propertyInfo.Name, mapping);
                indexes.Add(propertyInfo.Name, columnCount);
                ++columnCount;
            }
            return (IStringPropertyMapping)mapping;
        }

        private static PropertyInfo getProperty<TProp>(Expression<Func<TEntity, TProp>> property)
        {
            if (property == null)
            {
                throw new ArgumentNullException("property");
            }
            MemberExpression member = property.Body as MemberExpression;
            if (member == null)
            {
                throw new ArgumentException(Resources.BadPropertySelector, "property");
            }
            PropertyInfo propertyInfo = member.Member as PropertyInfo;
            if (propertyInfo == null)
            {
                throw new ArgumentException(Resources.BadPropertySelector, "property");
            }
            if (!propertyInfo.DeclaringType.IsAssignableFrom(typeof(TEntity)))
            {
                throw new ArgumentException(Resources.BadPropertySelector, "property");
            }
            return propertyInfo;
        }

        public IEnumerable<TEntity> Read(string fileName)
        {
            SeparatedValueSchema schema = getSchema();
            using (IReader reader = new SeparatedValueReader(fileName, schema))
            {
                return read(reader);
            }
        }

        public IEnumerable<TEntity> Read(string fileName, SeparatedValueOptions options)
        {
            SeparatedValueSchema schema = getSchema();
            using (IReader reader = new SeparatedValueReader(fileName, schema, options))
            {
                return read(reader);
            }
        }

        public IEnumerable<TEntity> Read(Stream stream)
        {
            SeparatedValueSchema schema = getSchema();
            using (IReader reader = new SeparatedValueReader(stream, schema))
            {
                return read(reader);
            }
        }

        public IEnumerable<TEntity> Read(Stream stream, SeparatedValueOptions options)
        {
            SeparatedValueSchema schema = getSchema();
            using (IReader reader = new SeparatedValueReader(stream, schema, options))
            {
                return read(reader);
            }
        }

        private IEnumerable<TEntity> read(IReader reader)
        {
            List<TEntity> entities = new List<TEntity>();
            while (reader.Read())
            {
                object[] values = reader.GetValues();
                TEntity entity = factory();
                mapProperties(values, entity);
                entities.Add(entity);
            }
            return entities;
        }

        private ColumnDefinition[] getColumnDefinitions()
        {
            ColumnDefinition[] definitions = new ColumnDefinition[columnCount];
            foreach (string propertyName in mappings.Keys)
            {
                IPropertyMapping mapping = mappings[propertyName];
                int index = indexes[propertyName];
                definitions[index] = mapping.ColumnDefinition;
            }
            return definitions;
        }

        private void mapProperties(object[] values, TEntity entity)
        {
            foreach (string propertyName in mappings.Keys)
            {
                IPropertyMapping mapping = mappings[propertyName];
                int index = indexes[propertyName];
                mapping.Property.SetValue(entity, values[index], null);
            }
        }

        public void Write(string fileName, IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            SeparatedValueSchema schema = getSchema();
            using (IWriter writer = new SeparatedValueWriter(fileName, schema))
            {
                write(writer, entities);
            }
        }

        public void Write(string fileName, SeparatedValueOptions options, IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            SeparatedValueSchema schema = getSchema();
            using (IWriter writer = new SeparatedValueWriter(fileName, schema, options))
            {
                write(writer, entities);
            }
        }

        public void Write(Stream stream, IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            SeparatedValueSchema schema = getSchema();
            using (IWriter writer = new SeparatedValueWriter(stream, schema))
            {
                write(writer, entities);
            }
        }

        public void Write(Stream stream, SeparatedValueOptions options, IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entities");
            }
            SeparatedValueSchema schema = getSchema();
            using (IWriter writer = new SeparatedValueWriter(stream, schema, options))
            {
                write(writer, entities);
            }
        }

        private void write(IWriter writer, IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities)
            {
                object[] values = new object[columnCount];
                foreach (string propertyName in mappings.Keys)
                {
                    IPropertyMapping mapping = mappings[propertyName];
                    int index = indexes[propertyName];
                    values[index] = mapping.Property.GetValue(entity, null);
                }
                writer.Write(values);
            }
        }

        public SeparatedValueSchema GetSchema()
        {
            return getSchema();
        }

        private SeparatedValueSchema getSchema()
        {
            ColumnDefinition[] definitions = getColumnDefinitions();
            SeparatedValueSchema schema = new SeparatedValueSchema();
            foreach (ColumnDefinition definition in definitions)
            {
                schema.AddColumn(definition);
            }
            return schema;
        }
    }
}
