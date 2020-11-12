using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "JointNullSpaceConfiguration" defined in "JointNullSpaceConfiguration.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointNullSpaceConfiguration.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointNullSpaceConfiguration.idl instead.
*
*/
public class JointNullSpaceConfigurationPubSubType : Halodi.CDR.TopicDataType<halodi_msgs.msg.JointNullSpaceConfiguration>
{
   public override string Name => "halodi_msgs::msg::dds_::JointNullSpaceConfiguration_";


   
   public override void serialize(halodi_msgs.msg.JointNullSpaceConfiguration data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.JointNullSpaceConfiguration data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointNullSpaceConfiguration data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointNullSpaceConfiguration data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.JointNamePubSubType.getCdrSerializedSize(data.joint, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.JointNullSpaceConfiguration data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.JointNamePubSubType.write(data.joint, cdr);

      cdr.write_type_6(data.q_nullspace);

   }

   public static void read(halodi_msgs.msg.JointNullSpaceConfiguration data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.joint = halodi_msgs.msg.JointNamePubSubType.Create();
      halodi_msgs.msg.JointNamePubSubType.read(data.joint, cdr);
      	
      data.q_nullspace=cdr.read_type_6();
      	

   }


    public static void Copy(halodi_msgs.msg.JointNullSpaceConfiguration src, halodi_msgs.msg.JointNullSpaceConfiguration target)
    {
        target.Set(src);
    }


}


}