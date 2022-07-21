using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class MpcPerformanceIndices : Halodi.CDR.DataType<MpcPerformanceIndices>
{

	public Halodi.CDR.TopicDataType<MpcPerformanceIndices> Type => new MpcPerformanceIndicesPubSubType();
	
   public float init_time;
   public float merit;
   public float cost;
   public float dynamics_violation_sse;
   public float equality_constraints_sse;
   public float equality_lagrangian;
   public float inequality_lagrangian;


   public void Set(MpcPerformanceIndices other)
   {
      init_time = other.init_time;

      merit = other.merit;

      cost = other.cost;

      dynamics_violation_sse = other.dynamics_violation_sse;

      equality_constraints_sse = other.equality_constraints_sse;

      equality_lagrangian = other.equality_lagrangian;

      inequality_lagrangian = other.inequality_lagrangian;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MpcPerformanceIndices {");
      builder.Append("init_time=");
      builder.Append(this.init_time);      builder.Append(", ");
      builder.Append("merit=");
      builder.Append(this.merit);      builder.Append(", ");
      builder.Append("cost=");
      builder.Append(this.cost);      builder.Append(", ");
      builder.Append("dynamics_violation_sse=");
      builder.Append(this.dynamics_violation_sse);      builder.Append(", ");
      builder.Append("equality_constraints_sse=");
      builder.Append(this.equality_constraints_sse);      builder.Append(", ");
      builder.Append("equality_lagrangian=");
      builder.Append(this.equality_lagrangian);      builder.Append(", ");
      builder.Append("inequality_lagrangian=");
      builder.Append(this.inequality_lagrangian);
      builder.Append("}");
      return builder.ToString();
   }
}


}