using System.IO;
namespace shape_msgs.msg
{

/**
* 
* Topic data type of the struct "SolidPrimitive" defined in "SolidPrimitive.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from SolidPrimitive.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit SolidPrimitive.idl instead.
*
*/
public class SolidPrimitivePubSubType : Halodi.CDR.TopicDataType<SolidPrimitive>
{
   public override string Name => "shape_msgs::msg::dds_::SolidPrimitive_";


   
   public override void serialize(shape_msgs.msg.SolidPrimitive data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, shape_msgs.msg.SolidPrimitive data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(shape_msgs.msg.SolidPrimitive data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(shape_msgs.msg.SolidPrimitive data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.dimensions.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(shape_msgs.msg.SolidPrimitive data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.type);

      	if(data.dimensions == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int dimensions_length = data.dimensions.Count;
            cdr.write_type_2(dimensions_length);
            for (int i0 = 0; i0 < dimensions_length; i0++)
            {
      			cdr.write_type_6(data.dimensions[i0]);
            }
        }
   }

   public static void read(shape_msgs.msg.SolidPrimitive data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.type=cdr.read_type_9();
      	

      int dimensions_length = cdr.read_type_2();
      data.dimensions = new System.Collections.Generic.List<double>(dimensions_length);
      for(int i = 0; i < dimensions_length; i++)
      {
      	data.dimensions.Add(cdr.read_type_6());
      	
      	
      }

      	

   }


    public static void Copy(shape_msgs.msg.SolidPrimitive src, shape_msgs.msg.SolidPrimitive target)
    {
        target.Set(src);
    }


}


}