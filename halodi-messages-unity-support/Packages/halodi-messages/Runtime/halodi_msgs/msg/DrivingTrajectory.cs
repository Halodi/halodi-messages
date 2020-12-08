using System.Text;
namespace halodi_msgs.msg
{


[System.Serializable]
public class DrivingTrajectory : Halodi.CDR.DataType<DrivingTrajectory>
{

	public Halodi.CDR.TopicDataType<DrivingTrajectory> Type => new DrivingTrajectoryPubSubType();
	
   public double look_ahead_distance;
   public double K;
   public System.Collections.Generic.List<halodi_msgs.msg.DrivingTrajectoryPoint> trajectory_points;


   public void Set(DrivingTrajectory other)
   {
      look_ahead_distance = other.look_ahead_distance;

      K = other.K;


      if(other.trajectory_points == null)
      {
      	trajectory_points = null;
      }
      else
      {
      	trajectory_points = new System.Collections.Generic.List<halodi_msgs.msg.DrivingTrajectoryPoint>(other.trajectory_points.Count);
      	for(int i1 = 0; i1 < other.trajectory_points.Count; i1++)
      	{
      		if(other.trajectory_points[i1] == null)
      		{
      			trajectory_points.Add(null);
      		}
      		else
      		{
      			halodi_msgs.msg.DrivingTrajectoryPoint newElement = halodi_msgs.msg.DrivingTrajectoryPointPubSubType.Create();
      	   		halodi_msgs.msg.DrivingTrajectoryPointPubSubType.Copy(other.trajectory_points[i1], newElement);
      	   		trajectory_points.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("DrivingTrajectory {");
      builder.Append("look_ahead_distance=");
      builder.Append(this.look_ahead_distance);      builder.Append(", ");
      builder.Append("K=");
      builder.Append(this.K);      builder.Append(", ");
      builder.Append("trajectory_points=");
      builder.Append(this.trajectory_points);
      builder.Append("}");
      return builder.ToString();
   }
}


}