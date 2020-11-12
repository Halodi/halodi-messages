using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "JointMeasurement" defined in "JointMeasurement.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from JointMeasurement.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit JointMeasurement.idl instead.
*
*/
public class JointMeasurementPubSubType : Halodi.CDR.TopicDataType<halodi_msgs.msg.JointMeasurement>
{
   public override string Name => "halodi_msgs::msg::dds_::JointMeasurement_";


   
   public override void serialize(halodi_msgs.msg.JointMeasurement data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.JointMeasurement data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointMeasurement data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.JointMeasurement data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += halodi_msgs.msg.JointNamePubSubType.getCdrSerializedSize(data.joint, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.JointMeasurement data, Halodi.CDR.CDRSerializer cdr)
   {
      halodi_msgs.msg.JointNamePubSubType.write(data.joint, cdr);

      cdr.write_type_6(data.position);

      cdr.write_type_6(data.velocity);

      cdr.write_type_6(data.measuredEffort);

      cdr.write_type_6(data.desiredEffort);

   }

   public static void read(halodi_msgs.msg.JointMeasurement data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.joint = halodi_msgs.msg.JointNamePubSubType.Create();
      halodi_msgs.msg.JointNamePubSubType.read(data.joint, cdr);
      	
      data.position=cdr.read_type_6();
      	
      data.velocity=cdr.read_type_6();
      	
      data.measuredEffort=cdr.read_type_6();
      	
      data.desiredEffort=cdr.read_type_6();
      	

   }


    public static void Copy(halodi_msgs.msg.JointMeasurement src, halodi_msgs.msg.JointMeasurement target)
    {
        target.Set(src);
    }


}


}