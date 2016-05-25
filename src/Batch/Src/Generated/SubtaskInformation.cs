//****************************************
// This file was autogenerated by a tool.
// Do not modify it.
//****************************************
namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about an Azure Batch subtask.
    /// </summary>
    public partial class SubtaskInformation : IPropertyMetadata
    {
        private readonly ComputeNodeInformation computeNodeInformation;
        private readonly DateTime? endTime;
        private readonly int? exitCode;
        private readonly int? id;
        private readonly Common.TaskState? previousState;
        private readonly DateTime? previousStateTransitionTime;
        private readonly TaskSchedulingError schedulingError;
        private readonly DateTime? startTime;
        private readonly Common.TaskState? state;
        private readonly DateTime? stateTransitionTime;

        #region Constructors

        internal SubtaskInformation(Models.SubtaskInformation protocolObject)
        {
            this.computeNodeInformation = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.NodeInfo, o => new ComputeNodeInformation(o).Freeze());
            this.endTime = protocolObject.EndTime;
            this.exitCode = protocolObject.ExitCode;
            this.id = protocolObject.Id;
            this.previousState = UtilitiesInternal.MapNullableEnum<Common.TaskState>(protocolObject.PreviousState);
            this.previousStateTransitionTime = protocolObject.PreviousStateTransitionTime;
            this.schedulingError = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.SchedulingError, o => new TaskSchedulingError(o).Freeze());
            this.startTime = protocolObject.StartTime;
            this.state = UtilitiesInternal.MapNullableEnum<Common.TaskState>(protocolObject.State);
            this.stateTransitionTime = protocolObject.StateTransitionTime;
        }

        #endregion Constructors

        #region SubtaskInformation

        /// <summary>
        /// Gets the information about the compute node on which the subtask ran.
        /// </summary>
        public ComputeNodeInformation ComputeNodeInformation
        {
            get { return this.computeNodeInformation; }
        }

        /// <summary>
        /// Gets the time at which the subtask completed. This property is set only if the subtask is in the Completed state.
        /// </summary>
        public DateTime? EndTime
        {
            get { return this.endTime; }
        }

        /// <summary>
        /// Gets the exit code of the subtask. This property is set only if the subtask is in Completed state.
        /// </summary>
        public int? ExitCode
        {
            get { return this.exitCode; }
        }

        /// <summary>
        /// Gets the id of the subtask.
        /// </summary>
        public int? Id
        {
            get { return this.id; }
        }

        /// <summary>
        /// Gets the previous state of the subtask. This property is not set if the subtask is in its initial active state.
        /// </summary>
        public Common.TaskState? PreviousState
        {
            get { return this.previousState; }
        }

        /// <summary>
        /// Gets the time at which the subtask entered its previous state. This property is not set if the subtask is in 
        /// its initial active state.
        /// </summary>
        public DateTime? PreviousStateTransitionTime
        {
            get { return this.previousStateTransitionTime; }
        }

        /// <summary>
        /// Gets the details of any error encountered scheduling the subtask.
        /// </summary>
        public TaskSchedulingError SchedulingError
        {
            get { return this.schedulingError; }
        }

        /// <summary>
        /// Gets the time at which the subtask started running. If the subtask has been restarted or retried, this is the 
        /// most recent time at which the subtask started running.
        /// </summary>
        public DateTime? StartTime
        {
            get { return this.startTime; }
        }

        /// <summary>
        /// Gets the current state of the subtask.
        /// </summary>
        public Common.TaskState? State
        {
            get { return this.state; }
        }

        /// <summary>
        /// Gets the time at which the subtask entered its current state.
        /// </summary>
        public DateTime? StateTransitionTime
        {
            get { return this.stateTransitionTime; }
        }

        #endregion // SubtaskInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}