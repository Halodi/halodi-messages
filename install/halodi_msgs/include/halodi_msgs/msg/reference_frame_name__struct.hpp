// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/ReferenceFrameName.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__REFERENCE_FRAME_NAME__STRUCT_HPP_
#define HALODI_MSGS__MSG__REFERENCE_FRAME_NAME__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__ReferenceFrameName __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__ReferenceFrameName __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct ReferenceFrameName_
{
  using Type = ReferenceFrameName_<ContainerAllocator>;

  explicit ReferenceFrameName_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->frame_id = 0l;
    }
  }

  explicit ReferenceFrameName_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->frame_id = 0l;
    }
  }

  // field types and members
  using _frame_id_type =
    int32_t;
  _frame_id_type frame_id;

  // setters for named parameter idiom
  Type & set__frame_id(
    const int32_t & _arg)
  {
    this->frame_id = _arg;
    return *this;
  }

  // constant declarations
  static constexpr int32_t WORLD =
    0;
  static constexpr int32_t PELVIS =
    1;
  static constexpr int32_t BASE =
    2;
  static constexpr int32_t LEFT_HAND =
    3;
  static constexpr int32_t RIGHT_HAND =
    4;
  static constexpr int32_t HEAD =
    5;

  // pointer types
  using RawPtr =
    halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__ReferenceFrameName
    std::shared_ptr<halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__ReferenceFrameName
    std::shared_ptr<halodi_msgs::msg::ReferenceFrameName_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const ReferenceFrameName_ & other) const
  {
    if (this->frame_id != other.frame_id) {
      return false;
    }
    return true;
  }
  bool operator!=(const ReferenceFrameName_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct ReferenceFrameName_

// alias to use template instance with default allocator
using ReferenceFrameName =
  halodi_msgs::msg::ReferenceFrameName_<std::allocator<void>>;

// constant definitions
template<typename ContainerAllocator>
constexpr int32_t ReferenceFrameName_<ContainerAllocator>::WORLD;
template<typename ContainerAllocator>
constexpr int32_t ReferenceFrameName_<ContainerAllocator>::PELVIS;
template<typename ContainerAllocator>
constexpr int32_t ReferenceFrameName_<ContainerAllocator>::BASE;
template<typename ContainerAllocator>
constexpr int32_t ReferenceFrameName_<ContainerAllocator>::LEFT_HAND;
template<typename ContainerAllocator>
constexpr int32_t ReferenceFrameName_<ContainerAllocator>::RIGHT_HAND;
template<typename ContainerAllocator>
constexpr int32_t ReferenceFrameName_<ContainerAllocator>::HEAD;

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__REFERENCE_FRAME_NAME__STRUCT_HPP_
