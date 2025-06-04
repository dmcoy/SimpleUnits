using System;
using System.Collections.Generic;

namespace SimpleUnits
{
    /// <summary>
    /// Provides methods for registering units, defining conversions, and converting values between different units.
    /// </summary>
    /// <remarks>
    /// This static class manages unit types and their base units, allows registration of conversion functions between units,
    /// and performs conversions between compatible units. All conversions must be registered before use.
    /// </remarks>
    internal static class UnitConverter
    {
        private readonly static Dictionary<(Enum, Enum), Func<double, double>> _conversions = new Dictionary<(Enum, Enum), Func<double, double>>();
        private readonly static Dictionary<Type, BaseUnit> _unitTypeToBaseUnit = new Dictionary<Type, BaseUnit>();

        /// <summary>
        /// Registers a unit type and its corresponding base unit.
        /// </summary>
        /// <param name="unitType">The <see cref="Type"/> representing the unit enumeration.</param>
        /// <param name="baseUnit">The base unit associated with the unit type.</param>
        /// <exception cref="InvalidOperationException">Thrown if the unit type is already registered.</exception>
        internal static void RegisterUnit(Type unitType, BaseUnit baseUnit)
        {
#if NETSTANDARD2_0
            if (_unitTypeToBaseUnit.ContainsKey(unitType))
            {
                throw new InvalidOperationException($"Base unit already registered for {unitType.Name}");
            }
            _unitTypeToBaseUnit.Add(unitType, baseUnit);
#else
            if (!_unitTypeToBaseUnit.TryAdd(unitType, baseUnit))
            {
                throw new InvalidOperationException($"Base unit already registered for {unitType.Name}");
            }
#endif
        }

        /// <summary>
        /// Registers a conversion function between two units of the same base type.
        /// </summary>
        /// <param name="fromUnit">The source unit enumeration value.</param>
        /// <param name="toUnit">The target unit enumeration value.</param>
        /// <param name="conversion">A function that converts a value from the source unit to the target unit.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the base units do not match or if a conversion is already registered for the specified units.
        /// </exception>
        internal static void RegisterConversion(Enum fromUnit, Enum toUnit, Func<double, double> conversion)
        {
            if (!BaseUnitsMatch(fromUnit, toUnit))
            {
                throw new InvalidOperationException($"Cannot register conversion from {fromUnit} to {toUnit}");
            }

#if NETSTANDARD2_0
            if (_conversions.ContainsKey((fromUnit, toUnit)))
            {
                throw new InvalidOperationException($"Conversion already registered for {fromUnit} to {toUnit}");
            }
            _conversions.Add((fromUnit, toUnit), conversion);
#else
            if (!_conversions.TryAdd((fromUnit, toUnit), conversion))
            {
                throw new InvalidOperationException($"Conversion already registered for {fromUnit} to {toUnit}");
            }
#endif
        }

        /// <summary>
        /// Converts a value from one unit to another compatible unit.
        /// </summary>
        /// <param name="value">The numeric value to convert.</param>
        /// <param name="fromUnit">The source unit enumeration value.</param>
        /// <param name="toUnit">The target unit enumeration value.</param>
        /// <returns>The converted value in the target unit as a double.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the units are not compatible or if no conversion is defined for the specified units.
        /// </exception>
        internal static double Convert(double value, Enum fromUnit, Enum toUnit)
        {
            if (fromUnit.Equals(toUnit))
            {
                return value;
            }

            if (!BaseUnitsMatch(fromUnit, toUnit))
            {
                throw new ArgumentException($"Cannot convert {fromUnit} to {toUnit}");
            }

            if (_conversions.TryGetValue((fromUnit, toUnit), out var conversion))
            {
                return conversion(value);
            }

            throw new ArgumentException($"No conversion defined for {fromUnit} to {toUnit}");
        }

        /// <summary>
        /// Determines whether two units share the same base unit.
        /// </summary>
        /// <param name="fromUnit">The first unit enumeration value.</param>
        /// <param name="toUnit">The second unit enumeration value.</param>
        /// <returns><c>true</c> if both units have the same base unit; otherwise, <c>false</c>.</returns>
        private static bool BaseUnitsMatch(Enum fromUnit, Enum toUnit)
        {
            var fromBaseUnit = _unitTypeToBaseUnit[fromUnit.GetType()];
            var toBaseUnit = _unitTypeToBaseUnit[toUnit.GetType()];
            return fromBaseUnit == toBaseUnit;
        }
    }

}
