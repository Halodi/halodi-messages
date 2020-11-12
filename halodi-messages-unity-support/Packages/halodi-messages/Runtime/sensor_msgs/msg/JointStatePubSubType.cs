using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "JointState" defined in "JointState.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointState.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointState.idl instead.
*
*/
public class JointStatePubSubType : Halodi.CDR.TopicDataType<sensor_msgs.msg.JointState>
{
   public override string Name => "sensor_msgs::msg::dds_::JointState_";


   
   public override void serialize(sensor_msgs.msg.JointState data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.JointState data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.JointState data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.JointState data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.name.Count; ++i0)
      {
          current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name[i0].Length + 1;
      }
      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.position.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.velocity.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.effort.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.JointState data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      	if(data.name == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int name_length = data.name.Count;
            cdr.write_type_2(name_length);
            for (int i0 = 0; i0 < name_length; i0++)
            {
      			cdr.write_type_d(data.name[i0]);
            }
        }
      	if(data.position == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int position_length = data.position.Count;
            cdr.write_type_2(position_length);
            for (int i0 = 0; i0 < position_length; i0++)
            {
      			cdr.write_type_6(data.position[i0]);
            }
        }
      	if(data.velocity == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int velocity_length = data.velocity.Count;
            cdr.write_type_2(velocity_length);
            for (int i0 = 0; i0 < velocity_length; i0++)
            {
      			cdr.write_type_6(data.velocity[i0]);
            }
        }
      	if(data.effort == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int effort_length = data.effort.Count;
            cdr.write_type_2(effort_length);
            for (int i0 = 0; i0 < effort_length; i0++)
            {
      			cdr.write_type_6(data.effort[i0]);
            }
        }
   }

   public static void read(sensor_msgs.msg.JointState data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int name_length = cdr.read_type_2();
      data.name = new System.Collections.Generic.List<string>(name_length);
      for(int i = 0; i < name_length; i++)
      {
      	data.name.Add(cdr.read_type_d());	
      	
      }

      	

      int position_length = cdr.read_type_2();
      data.position = new System.Collections.Generic.List<double>(position_length);
      for(int i = 0; i < position_length; i++)
      {
      	data.position.Add(cdr.read_type_6());
      	
      	
      }

      	

      int velocity_length = cdr.read_type_2();
      data.velocity = new System.Collections.Generic.List<double>(velocity_length);
      for(int i = 0; i < velocity_length; i++)
      {
      	data.velocity.Add(cdr.read_type_6());
      	
      	
      }

      	

      int effort_length = cdr.read_type_2();
      data.effort = new System.Collections.Generic.List<double>(effort_length);
      for(int i = 0; i < effort_length; i++)
      {
      	data.effort.Add(cdr.read_type_6());
      	
      	
      }

      	

   }


    public static void Copy(sensor_msgs.msg.JointState src, sensor_msgs.msg.JointState target)
    {
        target.Set(src);
    }


}


}