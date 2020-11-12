using System.Text;
namespace visualization_msgs.msg
{


[System.Serializable]
public class InteractiveMarkerInit
{
   /**
            * Identifying string. Must be unique in the topic namespace
            * that this server works on.
            */
   public string server_id;
   /**
            * Sequence number.
            * The client will use this to detect if it has missed a subsequent
            * update.  Every update message will have the same sequence number as
            * an init message.  Clients will likely want to unsubscribe from the
            * init topic after a successful initialization to avoid receiving
            * duplicate data.
            */
   public ulong seq_num;
   /**
            * All markers.
            */
   public System.Collections.Generic.List<visualization_msgs.msg.InteractiveMarker> markers;


   public void Set(InteractiveMarkerInit other)
   {
      server_id = other.server_id;

      seq_num = other.seq_num;


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
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("InteractiveMarkerInit {");
      builder.Append("server_id=");
      builder.Append(this.server_id);      builder.Append(", ");
      builder.Append("seq_num=");
      builder.Append(this.seq_num);      builder.Append(", ");
      builder.Append("markers=");
      builder.Append(this.markers);
      builder.Append("}");
      return builder.ToString();
   }
}


}