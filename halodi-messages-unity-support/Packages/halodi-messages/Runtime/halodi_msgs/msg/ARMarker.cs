using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class ARMarker
{
   public string data;
   public System.Collections.Generic.List<geometry_msgs.msg.Point> points;
   public geometry_msgs.msg.PoseStamped pose;


   public void Set(ARMarker other)
   {
      data = other.data;


      if(other.points == null)
      {
      	points = null;
      }
      else
      {
      	points = new System.Collections.Generic.List<geometry_msgs.msg.Point>(other.points.Count);
      	for(int i1 = 0; i1 < other.points.Count; i1++)
      	{
      		if(other.points[i1] == null)
      		{
      			points.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Point newElement = geometry_msgs.msg.PointPubSubType.Create();
      	   		geometry_msgs.msg.PointPubSubType.Copy(other.points[i1], newElement);
      	   		points.Add(newElement);
      		}	}
      }
      geometry_msgs.msg.PoseStampedPubSubType.Copy(other.pose, pose);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ARMarker {");
      builder.Append("data=");
      builder.Append(this.data);      builder.Append(", ");
      builder.Append("points=");
      builder.Append(this.points);      builder.Append(", ");
      builder.Append("pose=");
      builder.Append(this.pose);
      builder.Append("}");
      return builder.ToString();
   }
}


}