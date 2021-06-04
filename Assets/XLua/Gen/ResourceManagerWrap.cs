#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class ResourceManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ResourceManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadUIAsset", _m_LoadUIAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAsset", _m_LoadAsset);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new ResourceManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ResourceManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadUIAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResourceManager gen_to_be_invoked = (ResourceManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.Object>>(L, 3)) 
                {
                    string __path = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.Object> _callBack = translator.GetDelegate<System.Action<UnityEngine.Object>>(L, 3);
                    
                    gen_to_be_invoked.LoadUIAsset( __path, _callBack );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string __path = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.LoadUIAsset( __path );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ResourceManager.LoadUIAsset!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ResourceManager gen_to_be_invoked = (ResourceManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.GameObject>>(L, 3)&& translator.Assignable<ResourceLoadType>(L, 4)&& translator.Assignable<ResourceLoadMethod>(L, 5)) 
                {
                    string __path = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.GameObject> _callback = translator.GetDelegate<System.Action<UnityEngine.GameObject>>(L, 3);
                    ResourceLoadType __loadType;translator.Get(L, 4, out __loadType);
                    ResourceLoadMethod _loadMethod;translator.Get(L, 5, out _loadMethod);
                    
                    gen_to_be_invoked.LoadAsset( __path, _callback, __loadType, _loadMethod );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.GameObject>>(L, 3)&& translator.Assignable<ResourceLoadType>(L, 4)) 
                {
                    string __path = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.GameObject> _callback = translator.GetDelegate<System.Action<UnityEngine.GameObject>>(L, 3);
                    ResourceLoadType __loadType;translator.Get(L, 4, out __loadType);
                    
                    gen_to_be_invoked.LoadAsset( __path, _callback, __loadType );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.GameObject>>(L, 3)) 
                {
                    string __path = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.GameObject> _callback = translator.GetDelegate<System.Action<UnityEngine.GameObject>>(L, 3);
                    
                    gen_to_be_invoked.LoadAsset( __path, _callback );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string __path = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.LoadAsset( __path );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to ResourceManager.LoadAsset!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
