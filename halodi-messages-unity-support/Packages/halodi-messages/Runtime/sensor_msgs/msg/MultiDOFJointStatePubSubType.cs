using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "MultiDOFJointState" defined in "MultiDOFJointState.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MultiDOFJointState.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MultiDOFJointState.idl instead.
*
*/
public class MultiDOFJointStatePubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.MultiDOFJointState>
{
   public override string Name => "sensor_msgs::msg::dds_::MultiDOFJointState_";


   
   public override void serialize(sensor_msgs.msg.MultiDOFJointState data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.MultiDOFJointState data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.MultiDOFJointState data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.MultiDOFJointState data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.joint_names.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.joint_names[i0].Length + 1;
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.transforms.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TransformPubSubType.getCdrSerializedSize(data.transforms[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.twist.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.TwistPubSubType.getCdrSerializedSize(data.twist[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.wrench.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.WrenchPubSubType.getCdrSerializedSize(data.wrench[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.MultiDOFJointState data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      	if(data.joint_names == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int joint_names_length = data.joint_names.Count;
            cdr.write_type_2(joint_names_length);
            for (int i0 = 0; i0 < joint_names_length; i0++)
            {
      			cdr.write_type_d(data.joint_names[i0]);
            }
        }
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
      	if(data.twist == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int twist_length = data.twist.Count;
            cdr.write_type_2(twist_length);
            for (int i0 = 0; i0 < twist_length; i0++)
            {
      			geometry_msgs.msg.TwistPubSubType.write(data.twist[i0], cdr);	      }
        }
      	if(data.wrench == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int wrench_length = data.wrench.Count;
            cdr.write_type_2(wrench_length);
            for (int i0 = 0; i0 < wrench_length; i0++)
            {
      			geometry_msgs.msg.WrenchPubSubType.write(data.wrench[i0], cdr);	      }
        }
   }

   public static void read(sensor_msgs.msg.MultiDOFJointState data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int joint_names_length = cdr.read_type_2();
      data.joint_names = new System.Collections.Generic.List<string>(joint_names_length);
      for(int i = 0; i < joint_names_length; i++)
      {
      	data.joint_names.Add(cdr.read_type_d());	
      	
      }

      	

      int transforms_length = cdr.read_type_2();
      data.transforms = new System.Collections.Generic.List<geometry_msgs.msg.Transform>(transforms_length);
      for(int i = 0; i < transforms_length; i++)
      {
      	geometry_msgs.msg.Transform new_transforms = geometry_msgs.msg.TransformPubSubType.Create(); 
      	geometry_msgs.msg.TransformPubSubType.read(new_transforms, cdr);
      	data.transforms.Add(new_transforms);	
      	
      }

      	

      int twist_length = cdr.read_type_2();
      data.twist = new System.Collections.Generic.List<geometry_msgs.msg.Twist>(twist_length);
      for(int i = 0; i < twist_length; i++)
      {
      	geometry_msgs.msg.Twist new_twist = geometry_msgs.msg.TwistPubSubType.Create(); 
      	geometry_msgs.msg.TwistPubSubType.read(new_twist, cdr);
      	data.twist.Add(new_twist);	
      	
      }

      	

      int wrench_length = cdr.read_type_2();
      data.wrench = new System.Collections.Generic.List<geometry_msgs.msg.Wrench>(wrench_length);
      for(int i = 0; i < wrench_length; i++)
      {
      	geometry_msgs.msg.Wrench new_wrench = geometry_msgs.msg.WrenchPubSubType.Create(); 
      	geometry_msgs.msg.WrenchPubSubType.read(new_wrench, cdr);
      	data.wrench.Add(new_wrench);	
      	
      }

      	

   }


    public static void Copy(sensor_msgs.msg.MultiDOFJointState src, sensor_msgs.msg.MultiDOFJointState target)
    {
        target.Set(src);
    }


}


}