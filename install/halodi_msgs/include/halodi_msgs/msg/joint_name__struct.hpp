// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/JointName.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__JOINT_NAME__STRUCT_HPP_
#define HALODI_MSGS__MSG__JOINT_NAME__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__JointName __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__JointName __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct JointName_
{
  using Type = JointName_<ContainerAllocator>;

  explicit JointName_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->joint_id = 0l;
    }
  }

  explicit JointName_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->joint_id = 0l;
    }
  }

  // field types and members
  using _joint_id_type =
    int32_t;
  _joint_id_type joint_id;

  // setters for named parameter idiom
  Type & set__joint_id(
    const int32_t & _arg)
  {
    this->joint_id = _arg;
    return *this;
  }

  // constant declarations
  static constexpr int32_t HIP_YAW =
    0;
  static constexpr int32_t HIP_ROLL =
    1;
  static constexpr int32_t HIP_PITCH =
    2;
  static constexpr int32_t KNEE_PITCH =
    3;
  static constexpr int32_t ANKLE_ROLL =
    4;
  static constexpr int32_t ANKLE_PITCH =
    5;
  static constexpr int32_t LEFT_SHOULDER_PITCH =
    6;
  static constexpr int32_t LEFT_SHOULDER_ROLL =
    7;
  static constexpr int32_t LEFT_SHOULDER_YAW =
    8;
  static constexpr int32_t LEFT_ELBOW_PITCH =
    9;
  static constexpr int32_t LEFT_ELBOW_YAW =
    10;
  static constexpr int32_t LEFT_WRIST_PITCH =
    11;
  static constexpr int32_t LEFT_WRIST_ROLL =
    12;
  static constexpr int32_t RIGHT_SHOULDER_PITCH =
    13;
  static constexpr int32_t RIGHT_SHOULDER_ROLL =
    14;
  static constexpr int32_t RIGHT_SHOULDER_YAW =
    15;
  static constexpr int32_t RIGHT_ELBOW_PITCH =
    16;
  static constexpr int32_t RIGHT_ELBOW_YAW =
    17;
  static constexpr int32_t RIGHT_WRIST_PITCH =
    18;
  static constexpr int32_t RIGHT_WRIST_ROLL =
    19;
  static constexpr int32_t NECK_PITCH =
    20;
  static constexpr int32_t LEFT_WHEEL =
    21;
  static constexpr int32_t RIGHT_WHEEL =
    22;

  // pointer types
  using RawPtr =
    halodi_msgs::msg::JointName_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::JointName_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointName_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::JointName_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointName_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointName_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::JointName_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::JointName_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointName_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::JointName_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__JointName
    std::shared_ptr<halodi_msgs::msg::JointName_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__JointName
    std::shared_ptr<halodi_msgs::msg::JointName_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const JointName_ & other) const
  {
    if (this->joint_id != other.joint_id) {
      return false;
    }
    return true;
  }
  bool operator!=(const JointName_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct JointName_

// alias to use template instance with default allocator
using JointName =
  halodi_msgs::msg::JointName_<std::allocator<void>>;

// constant definitions
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::HIP_YAW;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::HIP_ROLL;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::HIP_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::KNEE_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::ANKLE_ROLL;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::ANKLE_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::LEFT_SHOULDER_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::LEFT_SHOULDER_ROLL;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::LEFT_SHOULDER_YAW;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::LEFT_ELBOW_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::LEFT_ELBOW_YAW;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::LEFT_WRIST_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::LEFT_WRIST_ROLL;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::RIGHT_SHOULDER_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::RIGHT_SHOULDER_ROLL;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::RIGHT_SHOULDER_YAW;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::RIGHT_ELBOW_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::RIGHT_ELBOW_YAW;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::RIGHT_WRIST_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::RIGHT_WRIST_ROLL;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::NECK_PITCH;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::LEFT_WHEEL;
template<typename ContainerAllocator>
constexpr int32_t JointName_<ContainerAllocator>::RIGHT_WHEEL;

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__JOINT_NAME__STRUCT_HPP_
