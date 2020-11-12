using System.IO;
namespace trajectory_msgs.msg
{

/**
* 
* Topic data type of the struct "MultiDOFJointTrajectoryPoint" defined in "MultiDOFJointTrajectoryPoint.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MultiDOFJointTrajectoryPoint.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MultiDOFJointTrajectoryPoint.idl instead.
*
*/
public class MultiDOFJointTrajectoryPointPubSubType : Halodi.CDR.TopicDataType<trajectory_msgs.msg.MultiDOFJointTrajectoryPoint>
{
   public override string Name => "trajectory_msgs::msg::dds_::MultiDOFJointTrajectoryPoint_";


   
   public override void serialize(trajectory_msgs.msg.MultiDOFJointTrajectoryPoint data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, trajectory_msgs.msg.MultiDOFJointTrajectoryPoint data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(trajectory_msgs.msg.MultiDOFJointTrajectoryPoint data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(trajectory_msgs.msg.MultiDOFJointTrajectoryPoint data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.transforms.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TransformPubSubType.getCdrSerializedSize(data.transforms[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.velocities.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TwistPubSubType.getCdrSerializedSize(data.velocities[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.accelerations.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TwistPubSubType.getCdrSerializedSize(data.accelerations[i0], current_alignment);}

      current_alignment += builtin_interfaces.msg.DurationPubSubType.getCdrSerializedSize(data.time_from_start, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(trajectory_msgs.msg.MultiDOFJointTrajectoryPoint data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.transforms == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int transforms_length = data.transforms.Count;
            cdr.write_type_2(transforms_length);
            for (int i0 = 0; i0 < transforms_length; i0++)
            {
      			geometry_msgs.msg.TransformPubSubType.write(data.transforms[i0], cdr);	      }
        }
      	if(data.velocities == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int velocities_length = data.velocities.Count;
            cdr.write_type_2(velocities_length);
            for (int i0 = 0; i0 < velocities_length; i0++)
            {
      			geometry_msgs.msg.TwistPubSubType.write(data.velocities[i0], cdr);	      }
        }
      	if(data.accelerations == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int accelerations_length = data.accelerations.Count;
            cdr.write_type_2(accelerations_length);
            for (int i0 = 0; i0 < accelerations_length; i0++)
            {
      			geometry_msgs.msg.TwistPubSubType.write(data.accelerations[i0], cdr);	      }
        }
      builtin_interfaces.msg.DurationPubSubType.write(data.time_from_start, cdr);

   }

   public static void read(trajectory_msgs.msg.MultiDOFJointTrajectoryPoint data, Halodi.CDR.CDRDeserializer cdr)
   {

      int transforms_length = cdr.read_type_2();
      data.transforms = new System.Collections.Generic.List<geometry_msgs.msg.Transform>(transforms_length);
      for(int i = 0; i < transforms_length; i++)
      {
      	geometry_msgs.msg.Transform new_transforms = geometry_msgs.msg.TransformPubSubType.Create(); 
      	geometry_msgs.msg.TransformPubSubType.read(new_transforms, cdr);
      	data.transforms.Add(new_transforms);	
      	
      }

      	

      int velocities_length = cdr.read_type_2();
      data.velocities = new System.Collections.Generic.List<geometry_msgs.msg.Twist>(velocities_length);
      for(int i = 0; i < velocities_length; i++)
      {
      	geometry_msgs.msg.Twist new_velocities = geometry_msgs.msg.TwistPubSubType.Create(); 
      	geometry_msgs.msg.TwistPubSubType.read(new_velocities, cdr);
      	data.velocities.Add(new_velocities);	
      	
      }

      	

      int accelerations_length = cdr.read_type_2();
      data.accelerations = new System.Collections.Generic.List<geometry_msgs.msg.Twist>(accelerations_length);
      for(int i = 0; i < accelerations_length; i++)
      {
      	geometry_msgs.msg.Twist new_accelerations = geometry_msgs.msg.TwistPubSubType.Create(); 
      	geometry_msgs.msg.TwistPubSubType.read(new_accelerations, cdr);
      	data.accelerations.Add(new_accelerations);	
      	
      }

      	
      data.time_from_start = builtin_interfaces.msg.DurationPubSubType.Create();
      builtin_interfaces.msg.DurationPubSubType.read(data.time_from_start, cdr);
      	

   }


    public static void Copy(trajectory_msgs.msg.MultiDOFJointTrajectoryPoint src, trajectory_msgs.msg.MultiDOFJointTrajectoryPoint target)
    {
        target.Set(src);
    }


}


}