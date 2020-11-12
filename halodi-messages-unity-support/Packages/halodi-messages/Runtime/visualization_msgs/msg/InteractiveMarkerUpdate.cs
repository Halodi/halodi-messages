using System.Text;
namespace visualization_msgs.msg
{


/**
       * Note: No guarantees on the order of processing.
       * Contents must be kept consistent by sender.
       */
[System.Serializable]
public class InteractiveMarkerUpdate
{
   /**
          * Type holds the purpose of this message.  It must be one of UPDATE or KEEP_ALIVE.
          * UPDATE: Incremental update to previous state.
          * The sequence number must be 1 higher than for
          * the previous update.
          * KEEP_ALIVE: Indicates the that the server is still living.
          * The sequence number does not increase.
          * No payload data should be filled out (markers, poses, or erases).
          */
   public const byte KEEP_ALIVE = (byte) 0;
   public const byte UPDATE = (byte) 1;
   /**
            * Identifying string. Must be unique in the topic namespace
            * that this server works on.
            */
   public string server_id;
   /**
            * Sequence number.
            * The client will use this to detect if it has missed an update.
            */
   public ulong seq_num;
   public byte type;
   /**
            * Markers to be added or updated
            */
   public System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarker> markers;
   /**
            * Poses of markers that should be moved
            */
   public System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarkerPose> poses;
   /**
            * Names of markers to be erased
            */
   public System.Collections.Generic.List<string> erases;


   public void Set(InteractiveMarkerUpdate other)
   {
      server_id = other.server_id;

      seq_num = other.seq_num;

      type = other.type;


      if(other.markers == null)
      {
      	markers = null;
      }
      else
      {
      	markers = new System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarker>(other.markers.Count);
      	for(int i1 = 0; i1 < other.markers.Count; i1++)
      	{
      		if(other.markers[i1] == null)
      		{
      			markers.Add(null);
      		}
      		else
      		{
      			visualization_msgs.msg.InteractiveMarker newElement = visualization_msgs.msg.InteractiveMarkerPubSubType.Create();
      	   		visualization_msgs.msg.InteractiveMarkerPubSubType.Copy(other.markers[i1], newElement);
      	   		markers.Add(newElement);
      		}	}
      }

      if(other.poses == null)
      {
      	poses = null;
      }
      else
      {
      	poses = new System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarkerPose>(other.poses.Count);
      	for(int i2 = 0; i2 < other.poses.Count; i2++)
      	{
      		if(other.poses[i2] == null)
      		{
      			poses.Add(null);
      		}
      		else
      		{
      			visualization_msgs.msg.InteractiveMarkerPose newElement = visualization_msgs.msg.InteractiveMarkerPosePubSubType.Create();
      	   		visualization_msgs.msg.InteractiveMarkerPosePubSubType.Copy(other.poses[i2], newElement);
      	   		poses.Add(newElement);
      		}	}
      }

      if(other.erases == null)
      {
      	erases = null;
      }
      else
      {
      	erases = new System.Collections.Generic.List<string>(other.erases.Count);
      	for(int i3 = 0; i3 < other.erases.Count; i3++)
      	{
         		erases.Add(other.erases[i3]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("InteractiveMarkerUpdate {");
      builder.Append("server_id=");
      builder.Append(this.server_id);      builder.Append(", ");
      builder.Append("seq_num=");
      builder.Append(this.seq_num);      builder.Append(", ");
      builder.Append("type=");
      builder.Append(this.type);      builder.Append(", ");
      builder.Append("markers=");
      builder.Append(this.markers);      builder.Append(", ");
      builder.Append("poses=");
      builder.Append(this.poses);      builder.Append(", ");
      builder.Append("erases=");
      builder.Append(this.erases);
      builder.Append("}");
      return builder.ToString();
   }
}


}