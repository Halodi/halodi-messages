using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class ARMarkers
{
   public std_msgs.msg.Header header;
   public System.Collections.Generic.List<halodi_msgs.msg.ARMarker> markers;


   public void Set(ARMarkers other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.markers == null)
      {
      	markers = null;
      }
      else
      {
      	markers = new System.Collections.Generic.List<halodi_msgs.msg.ARMarker>(other.markers.Count);
      	for(int i1 = 0; i1 < other.markers.Count; i1++)
      	{
      		if(other.markers[i1] == null)
      		{
      			markers.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.ARMarker newElement = halodi_msgs.msg.ARMarkerPubSubType.Create();
      	   		halodi_msgs.msg.ARMarkerPubSubType.Copy(other.markers[i1], newElement);
      	   		markers.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ARMarkers {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("markers=");
      builder.Append(this.markers);
      builder.Append("}");
      return builder.ToString();
   }
}


}