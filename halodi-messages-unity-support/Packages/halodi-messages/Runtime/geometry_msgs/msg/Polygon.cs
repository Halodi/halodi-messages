using System.Text;
namespace geometry_msgs.msg
{


/**
       * A specification of a polygon where the first and last points are assumed to be connected
       */
[System.Serializable]
public class Polygon
{
   public System.Collections.Generic.List<geometry_msgs.msg.Point32> points;


   public void Set(Polygon other)
   {

      if(other.points == null)
      {
      	points = null;
      }
      else
      {
      	points = new System.Collections.Generic.List<geometry_msgs.msg.Point32>(other.points.Count);
      	for(int i1 = 0; i1 < other.points.Count; i1++)
      	{
      		if(other.points[i1] == null)
      		{
      			points.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Point32 newElement = geometry_msgs.msg.Point32PubSubType.Create();
      	   		geometry_msgs.msg.Point32PubSubType.Copy(other.points[i1], newElement);
      	   		points.Add(newElement);
      		}	}
      }   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("Polygon {");
      builder.Append("points=");
      builder.Append(this.points);
      builder.Append("}");
      return builder.ToString();
   }
}


}