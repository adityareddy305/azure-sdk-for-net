// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Data flow flowlet. </summary>
    public partial class Flowlet : DataFlow
    {
        /// <summary> Initializes a new instance of <see cref="Flowlet"/>. </summary>
        public Flowlet()
        {
            Sources = new ChangeTrackingList<DataFlowSource>();
            Sinks = new ChangeTrackingList<DataFlowSink>();
            Transformations = new ChangeTrackingList<Transformation>();
            ScriptLines = new ChangeTrackingList<string>();
            Type = "Flowlet";
        }

        /// <summary> Initializes a new instance of <see cref="Flowlet"/>. </summary>
        /// <param name="type"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        /// <param name="sources"> List of sources in Flowlet. </param>
        /// <param name="sinks"> List of sinks in Flowlet. </param>
        /// <param name="transformations"> List of transformations in Flowlet. </param>
        /// <param name="script"> Flowlet script. </param>
        /// <param name="scriptLines"> Flowlet script lines. </param>
        internal Flowlet(string type, string description, IList<object> annotations, DataFlowFolder folder, IList<DataFlowSource> sources, IList<DataFlowSink> sinks, IList<Transformation> transformations, string script, IList<string> scriptLines) : base(type, description, annotations, folder)
        {
            Sources = sources;
            Sinks = sinks;
            Transformations = transformations;
            Script = script;
            ScriptLines = scriptLines;
            Type = type ?? "Flowlet";
        }

        /// <summary> List of sources in Flowlet. </summary>
        public IList<DataFlowSource> Sources { get; }
        /// <summary> List of sinks in Flowlet. </summary>
        public IList<DataFlowSink> Sinks { get; }
        /// <summary> List of transformations in Flowlet. </summary>
        public IList<Transformation> Transformations { get; }
        /// <summary> Flowlet script. </summary>
        public string Script { get; set; }
        /// <summary> Flowlet script lines. </summary>
        public IList<string> ScriptLines { get; }
    }
}
