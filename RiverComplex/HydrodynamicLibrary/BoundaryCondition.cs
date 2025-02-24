﻿//-----------------------------------------------------------------------------------
//       Реализация класса BoundaryCondition используемого для определения 
//                              граничных условий задачи
//-----------------------------------------------------------------------------------
//                 Реализация библиотеки для моделирования 
//                  гидродинамических и русловых процессов
//-----------------------------------------------------------------------------------
//            Модуль BedLoadLibrary для расчета донных деформаций 
//                (учет движения только влекомых наносов)
//                              Потапов И.И.
//                              Снигур К. С.
//                        - (C) Copyright 2017 -
//                          ALL RIGHT RESERVED
//                               13.01.17
//-----------------------------------------------------------------------------------
using System;
//-----------------------------------------------------------------------------------
namespace HydrodynamicLibrary
{
    /// <summary>
    /// Типы граничных условий решаемых 
    /// </summary>
    public enum TypeBoundaryCondition
    {
        /// <summary>
        /// Транзит потока
        /// </summary>
        Transit_Feed = 0,
        /// <summary>
        /// Первого рода - задан уровень потока
        /// </summary>
        Dirichlet_boundary_conditions,  
        /// <summary>
        /// Второго рода - задан градиент потока
        /// </summary>
        Neumann_boundary_conditions,   
        ///// <summary>
        ///// Переодические граничные условия
        ///// </summary>
        //Periodic_boundary_conditions
    }
    /// <summary>
    /// Класс для определения граничных условий задачи
    /// </summary>
    public class BoundaryCondition
    {
        /// <summary>
        /// Тип граничных условий на входе в область
        /// </summary>
        public TypeBoundaryCondition Inlet;
        /// <summary>
        /// Тип граничных условий на выходе из области
        /// </summary>
        public TypeBoundaryCondition Outlet;
        /// <summary>
        /// Значение величины (уровень скорость/глубина) на входе в область
        /// </summary>
        public double InletValue;
        /// <summary>
        /// Значение величины (уровень скорость/глубина) на выходе из области
        /// </summary>
        public double OutletValue;
        public BoundaryCondition()
        {
            Inlet = TypeBoundaryCondition.Dirichlet_boundary_conditions;
            Outlet = TypeBoundaryCondition.Dirichlet_boundary_conditions;
            InletValue = 0;
            OutletValue = 0;
        }
        public BoundaryCondition( TypeBoundaryCondition Inlet, TypeBoundaryCondition Outlet,
                double InletValue,  double OutletValue)
        {
            this.Inlet = Inlet;
            this.Outlet = Outlet;
            this.InletValue = InletValue;
            this.OutletValue = OutletValue;
           
        }
        public BoundaryCondition( BoundaryCondition BC)
        {
            this.Inlet = BC.Inlet;
            this.Outlet = BC.Outlet;
            this.InletValue = BC.InletValue;
            this.OutletValue = BC.OutletValue;
        }
    }
}
