using System.Text;
namespace ocs2_ros2_msgs.msg
{


[System.Serializable]
public class MpcPerformanceIndices : Halodi.CDR.DataType<MpcPerformanceIndices>
{

	public Halodi.CDR.TopicDataType<MpcPerformanceIndices> Type => new MpcPerformanceIndicesPubSubType();
	
   public float init_time;
   public float merit;
   public float total_cost;
   public float state_eq_constraint_ise;
   public float state_eq_constraint_penalty;
   public float state_eq_finalconstraint_sse;
   public float state_eq_finalconstraint_penalty;
   public float state_input_eq_constraint_ise;
   public float inequality_constraint_ise;
   public float inequality_constraint_penalty;


   public void Set(MpcPerformanceIndices other)
   {
      init_time = other.init_time;

      merit = other.merit;

      total_cost = other.total_cost;

      state_eq_constraint_ise = other.state_eq_constraint_ise;

      state_eq_constraint_penalty = other.state_eq_constraint_penalty;

      state_eq_finalconstraint_sse = other.state_eq_finalconstraint_sse;

      state_eq_finalconstraint_penalty = other.state_eq_finalconstraint_penalty;

      state_input_eq_constraint_ise = other.state_input_eq_constraint_ise;

      inequality_constraint_ise = other.inequality_constraint_ise;

      inequality_constraint_penalty = other.inequality_constraint_penalty;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MpcPerformanceIndices {");
      builder.Append("init_time=");
      builder.Append(this.init_time);      builder.Append(", ");
      builder.Append("merit=");
      builder.Append(this.merit);      builder.Append(", ");
      builder.Append("total_cost=");
      builder.Append(this.total_cost);      builder.Append(", ");
      builder.Append("state_eq_constraint_ise=");
      builder.Append(this.state_eq_constraint_ise);      builder.Append(", ");
      builder.Append("state_eq_constraint_penalty=");
      builder.Append(this.state_eq_constraint_penalty);      builder.Append(", ");
      builder.Append("state_eq_finalconstraint_sse=");
      builder.Append(this.state_eq_finalconstraint_sse);      builder.Append(", ");
      builder.Append("state_eq_finalconstraint_penalty=");
      builder.Append(this.state_eq_finalconstraint_penalty);      builder.Append(", ");
      builder.Append("state_input_eq_constraint_ise=");
      builder.Append(this.state_input_eq_constraint_ise);      builder.Append(", ");
      builder.Append("inequality_constraint_ise=");
      builder.Append(this.inequality_constraint_ise);      builder.Append(", ");
      builder.Append("inequality_constraint_penalty=");
      builder.Append(this.inequality_constraint_penalty);
      builder.Append("}");
      return builder.ToString();
   }
}


}