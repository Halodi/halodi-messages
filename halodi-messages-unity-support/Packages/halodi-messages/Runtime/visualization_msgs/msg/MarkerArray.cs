using System.Text;
namespace visualization_msgs.msg
{


[System.Serializable]
public class MarkerArray : Halodi.CDR.DataType<MarkerArray>
{

	public Halodi.CDR.TopicDataType<MarkerArray> Type => new MarkerArrayPubSubType();
	
   public System.Collections.Generic.List<visualization_msgs.msg.Marker> markers;


   public void Set(MarkerArray other)
   {

      if(other.markers == null)
      {
      	markers = null;
      }
      else
      {
      	markers = new System.Collections.Generic.List<visualization_msgs.msg.Marker>(other.markers.Count);
      	for(int i1 = 0; i1 < other.markers.Count; i1++)
      	{
      		if(other.markers[i1] == null)
      		{
      			markers.Add(null);
      		}
      		else
      		{
      			visualization_msgs.msg.Marker newElement = visualization_msgs.msg.MarkerPubSubType.Create();
      	   		visualization_msgs.msg.MarkerPubSubType.Copy(other.markers[i1], newElement);
      	   		markers.Add(newElement);
      		}	}
      }   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MarkerArray {");
      builder.Append("markers=");
      builder.Append(this.markers);
      builder.Append("}");
      return builder.ToString();
   }
}


}