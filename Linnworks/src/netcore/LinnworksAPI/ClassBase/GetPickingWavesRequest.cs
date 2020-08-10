using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request for getting all pickwaves irrespective of user. 
    /// </summary>
    public class GetPickingWavesRequest
	{
        /// <summary>
        /// Pickwave state (optional), if not supplied then all states. 
        /// </summary>
		public PickingWaveState? State;

        /// <summary>
        /// Location id for waves 
        /// </summary>
		public Guid LocationId;

        /// <summary>
        /// Detail level, if not supplied then all is assumed 
        /// </summary>
		public GetPickingWavesRequestDetailLevel DetailLevel;
	} 
}