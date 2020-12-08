using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "MultiArrayDimension" defined in "MultiArrayDimension.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MultiArrayDimension.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MultiArrayDimension.idl instead.
*
*/
public class MultiArrayDimensionPubSubType : Halodi.CDR.TopicDataType<MultiArrayDimension>
{
   public override string Name => "std_msgs::msg::dds_::MultiArrayDimension_";


   
   public override void serialize(std_msgs.msg.MultiArrayDimension data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.MultiArrayDimension data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.MultiArrayDimension data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.MultiArrayDimension data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.label.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.MultiArrayDimension data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.label);

      cdr.write_type_4(data.size);

      cdr.write_type_4(data.stride);

   }

   public static void read(std_msgs.msg.MultiArrayDimension data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.label = cdr.read_type_d();	
      data.size=cdr.read_type_4();
      	
      data.stride=cdr.read_type_4();
      	

   }


    public static void Copy(std_msgs.msg.MultiArrayDimension src, std_msgs.msg.MultiArrayDimension target)
    {
        target.Set(src);
    }


}


}