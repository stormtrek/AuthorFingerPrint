﻿using FingerPrint.Models.Interfaces.TypeInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerPrint.Controllers
{
    /// <summary>
    /// Interface to be implemented by an AnalysisController, i.e., a controller that will 
    /// track the groups actively being considered for analysis.
    /// </summary>
    /// <typeparam name="SingleCountType">The type of object being used to store a single collection of counts.</typeparam>
    public interface IAnalysisController<SingleCountType>
    {
        /// <summary>
        /// Gets the list of groups actively being considered for analysis.
        /// </summary>
        /// <returns>A list of groups.</returns>
        List<IGroupViewModel<SingleCountType>> GetActiveGroups();

        /// <summary>
        /// Adds the group passed in to the list of active groups.
        /// </summary>
        /// <param name="group">The group to be added to the list of active groups.</param>
        void AddToActiveGroups(IGroupViewModel<SingleCountType> group);

        /// <summary>
        /// Removes the group passed in from the list of active groups.
        /// </summary>
        /// <param name="group">The group to be removed from the list of active groups.</param>
        void RemoveFromActiveGroups(IGroupViewModel<SingleCountType> group);

        /// <summary>
        /// Determines whether the group in question is already active.
        /// </summary>
        /// <param name="group">The group that is to be looked for in the active group collection.</param>
        /// <returns>True if the group is already active, false otherwise.</returns>
        bool GroupIsActive(IGroupViewModel<SingleCountType> group);
    }
}