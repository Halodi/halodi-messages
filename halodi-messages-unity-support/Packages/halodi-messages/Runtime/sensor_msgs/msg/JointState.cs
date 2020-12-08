using System.Text;
namespace sensor_msgs.msg
{


/**
       * This is a message that holds data to describe the state of a set of torque controlled joints.
       * 
       * The state of each joint (revolute or prismatic) is defined by:
       * * the position of the joint (rad or m),
       * * the velocity of the joint (rad/s or m/s) and
       * * the effort that is applied in the joint (Nm or N).
       * 
       * Each joint is uniquely identified by its name
       * The header specifies the time at which the joint states were recorded. All the joint states
       * in one message have to be recorded at the same time.
       * 
       * This message consists of a multiple arrays, one for each part of the joint state.
       * The goal is to make each of the fields optional. When e.g. your joints have no
       * effort associated with them, you can leave the effort array empty.
       * 
       * All arrays in this message should have the same size, or be empty.
       * This is the only way to uniquely associate the joint name with the correct
       * states.
       */
[System.Serializable]
public class JointState : Halodi.CDR.DataType<JointState>
{

	public Halodi.CDR.TopicDataType<JointState> Type => new JointStatePubSubType();
	
   public std_msgs.msg.Header header;
   public System.Collections.Generic.List<string> name;
   public System.Collections.Generic.List<double> position;
   public System.Collections.Generic.List<double> velocity;
   public System.Collections.Generic.List<double> effort;


   public void Set(JointState other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.name == null)
      {
      	name = null;
      }
      else
      {
      	name = new System.Collections.Generic.List<string>(other.name.Count);
      	for(int i1 = 0; i1 < other.name.Count; i1++)
      	{
         		name.Add(other.name[i1]);
      	}
      }

      if(other.position == null)
      {
      	position = null;
      }
      else
      {
      	position = new System.Collections.Generic.List<double>(other.position.Count);
      	for(int i2 = 0; i2 < other.position.Count; i2++)
      	{
         		position.Add(other.position[i2]);
      	}
      }

      if(other.velocity == null)
      {
      	velocity = null;
      }
      else
      {
      	velocity = new System.Collections.Generic.List<double>(other.velocity.Count);
      	for(int i3 = 0; i3 < other.velocity.Count; i3++)
      	{
         		velocity.Add(other.velocity[i3]);
      	}
      }

      if(other.effort == null)
      {
      	effort = null;
      }
      else
      {
      	effort = new System.Collections.Generic.List<double>(other.effort.Count);
      	for(int i4 = 0; i4 < other.effort.Count; i4++)
      	{
         		effort.Add(other.effort[i4]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("JointState {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("position=");
      builder.Append(this.position);      builder.Append(", ");
      builder.Append("velocity=");
      builder.Append(this.velocity);      builder.Append(", ");
      builder.Append("effort=");
      builder.Append(this.effort);
      builder.Append("}");
      return builder.ToString();
   }
}


}